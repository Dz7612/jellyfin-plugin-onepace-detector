// FILE: Providers/OnePaceSeasonLocalProvider.cs
using System;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Services;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceSeasonLocalProvider : ILocalMetadataProvider<Season>
{
    private readonly ILogger<OnePaceSeasonLocalProvider> _logger;
    private readonly OnePaceGoogleSheetService _sheet;

    public OnePaceSeasonLocalProvider(
        ILogger<OnePaceSeasonLocalProvider> logger,
        OnePaceGoogleSheetService sheet)
    {
        _logger = logger;
        _sheet = sheet;
    }

    public string Name => "One Pace Season (Arc Descriptions Sheet)";

    public async Task<MetadataResult<Season>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Season>();

        if (info.IndexNumber is null)
            return result;

        if (info.Path is null ||
            info.Path.IndexOf("One Pace", StringComparison.OrdinalIgnoreCase) < 0)
            return result;

        var arcGuess = GuessArcFromPath(info.Path);
        if (string.IsNullOrWhiteSpace(arcGuess))
            return result;

        arcGuess = OnePaceGoogleSheetService.NormalizeArc(arcGuess);

        var arcRow = await _sheet.GetArcAsync(arcGuess, cancellationToken).ConfigureAwait(false);

        result.Item = new Season
        {
            IndexNumber = info.IndexNumber.Value,
            Name = arcGuess,
            Overview = arcRow?.Description
        };

        result.HasMetadata = true;

        _logger.LogInformation("OnePaceSeasonProvider(Sheet): Season {S} -> {Arc}", result.Item.IndexNumber, result.Item.Name);

        return result;
    }

    private static string? GuessArcFromPath(string path)
    {
        // Example folder: "[23-41] Syrup Village [En Dub][1080p]"
        var dir = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(path));
        if (string.IsNullOrWhiteSpace(dir))
            return null;

        dir = System.Text.RegularExpressions.Regex.Replace(dir, @"^\s*\[[^\]]+\]\s*", "");
        dir = System.Text.RegularExpressions.Regex.Replace(dir, @"\s*\[[^\]]+\]\s*", " ");
        dir = System.Text.RegularExpressions.Regex.Replace(dir, @"\s+", " ").Trim();

        return string.IsNullOrWhiteSpace(dir) ? null : dir;
    }
}
