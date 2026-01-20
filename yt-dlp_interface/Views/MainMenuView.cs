using Spectre.Console;
using yt_dlp_interface.Controllers;
using static yt_dlp_interface.Views.MainMenuEnum;

namespace yt_dlp_interface.Views
{
    public interface IMainMenuView
    {
        MainMenuOption Display();
    }

    public class MainMenuView : IMainMenuView
    {
        public MainMenuOption Display()
        {
            Console.Clear();

            var input = AnsiConsole.Prompt(
                new SelectionPrompt<MainMenuOption>()
                .AddChoices(Enum.GetValues<MainMenuOption>())
                .Title("[green]Choose an option::[/]")
                .HighlightStyle("green")
                .WrapAround());
            return input;
        }
    }
}
