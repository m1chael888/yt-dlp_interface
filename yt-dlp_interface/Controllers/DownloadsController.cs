using yt_dlp_interface.Views;
using static yt_dlp_interface.Views.MainMenuEnum;
using yt_dlp_interface.Models;
using yt_dlp_interface.Services;
using Spectre.Console;

namespace yt_dlp_interface.Controllers
{
    public interface IDownloadsController
    {
        public void ExecuteMainMenuOption(MainMenuOption option);
        void CallDownloadsView();
        void CallValidateService(DownloadDto Dto);
        void CallDownloadService(DownloadDto Dto);
        void MainMenu();
    }

    public class DownloadsController : IDownloadsController
    {
        private readonly IDownloadsView _downloadsView;
        private readonly IDownloadsService _downloadsService;
        private readonly IMainMenuView _mainMenuView;

        public DownloadsController(IDownloadsView downloadsView, IDownloadsService downloadsService, IMainMenuView mainMenuView)
        {
            _downloadsView = downloadsView;
            _downloadsService = downloadsService;
            _mainMenuView = mainMenuView;
        }

        public void ExecuteMainMenuOption(MainMenuOption option)
        {
            switch (option)
            {
                case MainMenuOption.Download:
                    CallDownloadsView();
                    break;
                case MainMenuOption.Exit:
                    AnsiConsole.MarkupLine("[green]Goodbye;;[/]");
                    Environment.Exit(0);
                    break;
            }
        }

        public void CallDownloadsView()
        {
            DownloadDto NewDto = _downloadsView.GetVideoDetails();
            CallValidateService(NewDto);
        }

        public void CallValidateService(DownloadDto Dto)
        {
            bool done = false;

            while (!done)
            {
                switch (_downloadsService.ValidateUrl(Dto))
                {
                    case true:
                        CallDownloadService(Dto);
                        done = true;
                    break;
                    case false:
                        // TODO: failed validation msg
                    break;
                }
            }
        }

        public void CallDownloadService(DownloadDto Dto)
        {
            AnsiConsole.MarkupLine($"\nDownloading. . .");
            _downloadsService.Download(Dto);
            Console.Clear();

            AnsiConsole.MarkupLine($"[green]{Dto.Url} successfully downloaded =)[/]\n");
            AnsiConsole.Markup("[grey]Press any key to return to main menu. . .[/]");
            Console.ReadKey();
            MainMenu();
        }

        public void MainMenu()
        {
            var option = _mainMenuView.Display();
            ExecuteMainMenuOption(option);
        }
    }
}