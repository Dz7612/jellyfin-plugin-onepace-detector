using Jellyfin.Plugin.OnePaceDetector.Providers;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Controller.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Jellyfin.Plugin.OnePaceDetector;

public sealed class ServiceRegistrator : IPluginServiceRegistrator
{
    public void RegisterServices(
        IServiceCollection services,
        IServerApplicationHost applicationHost)
    {
        // Register our One Pace episode metadata provider
        services.AddSingleton<
            ILocalMetadataProvider<Episode>,
            OnePaceEpisodeLocalProvider>();
    }
}
