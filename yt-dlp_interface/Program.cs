using Microsoft.Extensions.DependencyInjection;
using yt_dlp_interface.Controllers;
using yt_dlp_interface.Views;

namespace yt_dlp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IMainMenu, MainMenuView>();
            serviceCollection.AddScoped<IDownloadsController, DownloadsController>();
            serviceCollection.AddScoped<IDownloadsView, DownloadsView>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainMenu = serviceProvider.GetRequiredService<IMainMenu>();

            mainMenu.Display();
        }
    }
}
