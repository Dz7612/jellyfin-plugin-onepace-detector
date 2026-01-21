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

        // If you want, you can enforce Series name/overview here.
        // Leaving minimal so we don't override posters/etc.
        return Task.FromResult(result);
    }
}
