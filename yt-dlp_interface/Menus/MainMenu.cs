using Spectre.Console;
using static yt_dlp_interface.Menus.MainMenuEnum;

namespace yt_dlp_interface.Menus
{
    internal interface IMainMenu
    {
        void Display();
    }

    internal class MainMenu : IMainMenu
    {
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
                    
                }
            }
        }
    }
}
