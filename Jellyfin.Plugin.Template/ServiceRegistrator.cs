using Jellyfin.Plugin.OnePaceDetector.Providers;
using Jellyfin.Plugin.OnePaceDetector.Resolvers;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Controller.Resolvers;
using Microsoft.Extensions.DependencyInjection;

namespace Jellyfin.Plugin.OnePaceDetector;

public sealed class ServiceRegistrator : IPluginServiceRegistrator
{
    public void RegisterServices(
        IServiceCollection services,
        IServerApplicationHost applicationHost)
    {
        // Our resolver runs BEFORE Jellyfin's built-in TV resolver
        services.AddSingleton<IItemResolver, OnePaceEpisodeResolver>();

        // Our metadata provider (still useful for metadata refresh flows)
        services.AddSingleton<ILocalMetadataProvider<Episode>, OnePaceEpisodeLocalProvider>();
    }
}
