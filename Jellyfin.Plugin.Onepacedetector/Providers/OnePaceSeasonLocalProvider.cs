using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Data;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Providers;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceSeasonLocalProvider : ILocalMetadataProvider<Season>, IHasOrder, IMetadataProvider
{
    public string Name => "One Pace Detector (Local Season Metadata)";
    public int Order => -10;

    public Task<MetadataResult<Season>> GetMetadata(ItemInfo info, IDirectoryService directoryService, CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Season>();

        // Get season number from the parent directory name or info
        var seasonNumber = info.IndexNumber;

        if (seasonNumber is null)
        {
            // Try to extract from directory name
            var parentPath = Path.GetDirectoryName(info.Path);
            if (parentPath != null)
            {
                var dirName = Path.GetFileName(parentPath);
                if (int.TryParse(dirName, out int parsedSeason))
                {
                    seasonNumber = parsedSeason;
                }
            }
        }

        if (seasonNumber is null)
            return Task.FromResult(result);

        // Find arc by season number
        foreach (var kvp in OnePaceHardcodedData.ArcsByNormalizedTitle)
        {
            var arc = kvp.Value;
            if (arc.SeasonNumber != seasonNumber.Value)
                continue;

            var item = new Season
            {
                IndexNumber = seasonNumber.Value,
                Name = $"{seasonNumber.Value:00} - {arc.ArcTitle}",
                Overview = string.IsNullOrWhiteSpace(arc.Description) ? null : arc.Description
            };

            result.Item = item;
            result.HasMetadata = true;
            return Task.FromResult(result);
        }

        return Task.FromResult(result);
    }
}
