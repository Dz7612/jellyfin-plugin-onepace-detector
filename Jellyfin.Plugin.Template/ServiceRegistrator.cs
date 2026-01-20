// FILE: ServiceRegistrator.cs
using Jellyfin.Plugin.OnePaceDetector.Providers;
using Jellyfin.Plugin.OnePaceDetector.Resolvers;
using Jellyfin.Plugin.OnePaceDetector.Services;
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
        services.AddSingleton<OnePaceGoogleSheetService>();

        services.AddSingleton<IItemResolver, OnePaceEpisodeResolver>();
        services.AddSingleton<ILocalMetadataProvider<Episode>, OnePaceEpisodeLocalProvider>();
        services.AddSingleton<ILocalMetadataProvider<Season>, OnePaceSeasonLocalProvider>();
    }
}
