using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Providers;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceSeriesLocalProvider : ILocalMetadataProvider<Series>, IHasOrder, IMetadataProvider
{
    public string Name => "One Pace Detector (Local Series Metadata)";
    public int Order => -10;

    public Task<MetadataResult<Series>> GetMetadata(ItemInfo info, IDirectoryService directoryService, CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Series>();

        // Set the series name to "One Pace" so it shows correctly in Jellyfin
        var item = new Series
        {
            Name = "One Pace",
            Overview = "A fan edit of One Piece that removes filler content and pacing issues, creating a more manga-accurate viewing experience."
        };

        result.Item = item;
        result.HasMetadata = true;

        return Task.FromResult(result);
    }
}
