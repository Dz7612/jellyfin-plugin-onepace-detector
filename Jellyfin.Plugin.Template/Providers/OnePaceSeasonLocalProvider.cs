using System;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Metadata;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceSeasonLocalProvider : ILocalMetadataProvider<Season>
{
    private readonly ILogger<OnePaceSeasonLocalProvider> _logger;

    public OnePaceSeasonLocalProvider(ILogger<OnePaceSeasonLocalProvider> logger)
    {
        _logger = logger;
    }

    public string Name => "One Pace Season Metadata";

    public Task<MetadataResult<Season>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Season>();

        if (info.IndexNumber is null)
            return Task.FromResult(result);

        if (info.Path is null ||
            info.Path.IndexOf("One Pace", StringComparison.OrdinalIgnoreCase) < 0)
            return Task.FromResult(result);

        var seasonNumber = info.IndexNumber.Value;

        if (!OnePaceStaticMetadata.SeasonToArc.TryGetValue(seasonNumber, out var arc))
            return Task.FromResult(result);

        result.Item = new Season
        {
            IndexNumber = seasonNumber,
            Name = arc
        };

        result.HasMetadata = true;

        _logger.LogInformation(
            "OnePaceSeasonProvider: Season {S} -> {Arc}",
            seasonNumber,
            arc);

        return Task.FromResult(result);
    }
}
