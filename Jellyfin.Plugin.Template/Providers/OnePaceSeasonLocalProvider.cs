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

    public OnePaceSeasonLocalProvider(
        ILogger<OnePaceSeasonLocalProvider> logger)
    {
        _logger = logger;
    }

    public string Name => "One Pace Arc Metadata";

    public Task<MetadataResult<Season>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Season>();

        if (info.IndexNumber is null)
            return Task.FromResult(result);

        if (!OnePaceHardcodedData.SeasonToArc.TryGetValue(
                info.IndexNumber.Value,
                out var arc))
            return Task.FromResult(result);

        if (!OnePaceHardcodedData.Arcs.TryGetValue(arc, out var arcMeta))
            return Task.FromResult(result);

        result.Item = new Season
        {
            IndexNumber = info.IndexNumber.Value,
            Name = arcMeta.Title,
            Overview = arcMeta.Overview
        };

        result.HasMetadata = true;

        _logger.LogInformation(
            "OnePaceSeasonProvider: Season {Season} -> {Arc}",
            result.Item.IndexNumber,
            result.Item.Name);

        return Task.FromResult(result);
    }
}
