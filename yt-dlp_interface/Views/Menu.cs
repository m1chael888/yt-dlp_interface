using Spectre.Console;
using static yt_dlp_interface.Views.MenuEnums;

namespace yt_dlp_interface.Views
{
    internal class Menu
    {
        internal void ShowMain()
        {
            while (true)
            {
                var input = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOption>()
                .Title("[green]Choose an option::[/]")
                .AddChoices(Enum.GetValues<MenuOption>())
                .HighlightStyle("green")
                .WrapAround());

                switch (input)
                {
                    case MenuOption.a:

                        break;
                    case MenuOption.Exit:
                        AnsiConsole.MarkupLine("[green]Goodbye;;[/]");
                        break;
                }
            }
            
        }
    }
}
