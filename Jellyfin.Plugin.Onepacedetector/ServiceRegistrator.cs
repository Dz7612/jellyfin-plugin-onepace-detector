using Jellyfin.Plugin.OnePaceDetector.Providers;
using Microsoft.Extensions.DependencyInjection;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Resolvers;

namespace Jellyfin.Plugin.OnePaceDetector;

public sealed class ServiceRegistrator : IPluginServiceRegistrator
{
    public void RegisterServices(IServiceCollection services, IServerApplicationHost applicationHost)
    {
        services.AddSingleton<ILocalMetadataProvider<Episode>, OnePaceEpisodeLocalProvider>();
        services.AddSingleton<ILocalMetadataProvider<Season>, OnePaceSeasonLocalProvider>();
        services.AddSingleton<ILocalMetadataProvider<Series>, OnePaceSeriesLocalProvider>();
    }
}
