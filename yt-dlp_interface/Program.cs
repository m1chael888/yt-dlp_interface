using Microsoft.Extensions.DependencyInjection;
using yt_dlp_interface.Menus;

namespace yt_dlp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IMainMenu, MainMenu>();
            //serviceCollection.AddScoped<, >();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainMenu = serviceProvider.GetRequiredService<IMainMenu>();

            mainMenu.Display();
        }
    }
}
