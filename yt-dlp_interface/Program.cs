using Microsoft.Extensions.DependencyInjection;
using System.Text;
using yt_dlp_interface.Controllers;
using yt_dlp_interface.Services;
using yt_dlp_interface.Views;

namespace yt_dlp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IMainMenuView, MainMenuView>();
            serviceCollection.AddScoped<IDownloadsController, DownloadsController>();
            serviceCollection.AddScoped<IDownloadsView, DownloadsView>();
            serviceCollection.AddScoped<IDownloadsService, DownloadsService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainMenu = serviceProvider.GetRequiredService<IMainMenuView>();
            var option = mainMenu.Display();

            var controller = serviceProvider.GetRequiredService<IDownloadsController>();
            controller.ExecuteMainMenuOption(option);
        }
    }
}
