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

        // Season providers are messy: we rely on existing season number already assigned by resolver.
        // If Jellyfin hasn't assigned it yet, we can't do much here.
        if (info.IndexNumber is null)
            return Task.FromResult(result);

        var seasonNumber = info.IndexNumber.Value;

        // Find arc by season number
        foreach (var kvp in OnePaceHardcodedData.ArcsByNormalizedTitle)
        {
            var arc = kvp.Value;
            if (arc.SeasonNumber != seasonNumber)
                continue;

            var item = new Season
            {
                IndexNumber = seasonNumber,
                Name = $"{seasonNumber:00} - {arc.ArcTitle}",
                Overview = string.IsNullOrWhiteSpace(arc.Description) ? null : arc.Description
            };

            result.Item = item;
            result.HasMetadata = true;
            return Task.FromResult(result);
        }

        return Task.FromResult(result);
    }
}
