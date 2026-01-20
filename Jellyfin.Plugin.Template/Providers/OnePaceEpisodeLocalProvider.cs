using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Metadata;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceEpisodeLocalProvider : ILocalMetadataProvider<Episode>
{
    private readonly ILogger<OnePaceEpisodeLocalProvider> _logger;

    public OnePaceEpisodeLocalProvider(
        ILogger<OnePaceEpisodeLocalProvider> logger)
    {
        _logger = logger;
    }

    public string Name => "One Pace Episode Metadata";

    private static readonly Regex FileRegex = new(
        @"^\[One Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Task<MetadataResult<Episode>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Episode>();

        if (info.Path is null)
            return Task.FromResult(result);

        var fileName = Path.GetFileNameWithoutExtension(info.Path);
        if (string.IsNullOrWhiteSpace(fileName))
            return Task.FromResult(result);

        var match = FileRegex.Match(fileName);
        if (!match.Success)
            return Task.FromResult(result);

        var arc = OnePaceHardcodedData.NormalizeArc(match.Groups["arc"].Value);
        if (!int.TryParse(match.Groups["cut"].Value, out var part))
            return Task.FromResult(result);

        var key = OnePaceHardcodedData.Key(arc, part);
        if (!OnePaceHardcodedData.Episodes.TryGetValue(key, out var meta))
            return Task.FromResult(result);

        var isDub =
            info.Path.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0;

        result.Item = new Episode
        {
            Name = meta.Title + (isDub ? " (Dub)" : ""),
            Overview = meta.Overview,
            IndexNumber = part
        };

        result.HasMetadata = true;

        _logger.LogInformation(
            "OnePaceEpisodeProvider: {File} -> {Title}",
            fileName, result.Item.Name);

        return Task.FromResult(result);
    }
}
