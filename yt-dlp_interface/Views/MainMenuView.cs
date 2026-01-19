using Spectre.Console;
using yt_dlp_interface.Controllers;
using static yt_dlp_interface.Views.MainMenuEnum;

namespace yt_dlp_interface.Views
{
    public interface IMainMenu
    {
        void Display();
    }

    public class MainMenuView : IMainMenu
    {
        private readonly IDownloadsController _downloadsController;

        public MainMenuView(IDownloadsController downloadsController)
        {
            _downloadsController = downloadsController;
        }

        public void Display()
        {
            while (true)
            {
                var input = AnsiConsole.Prompt(
                    new SelectionPrompt<MainMenuOption>()
                    .AddChoices(Enum.GetValues<MainMenuOption>())
                    .Title("[green]Choose an option::[/]")
                    .HighlightStyle("green")
                    .WrapAround());

                switch (input)
                {
                    case MainMenuOption.Download:
                        _downloadsController.CallDownloadsView();
                        break;
                    case MainMenuOption.Exit:
                        AnsiConsole.MarkupLine("[green]Goodbye;;[/]");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
