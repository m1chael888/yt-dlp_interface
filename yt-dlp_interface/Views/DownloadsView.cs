using Spectre.Console;

namespace yt_dlp_interface.Views
{
    public interface IDownloadsView
    {
        void GetVideoDetails();
    }

    public class DownloadsView : IDownloadsView
    {
        public void GetVideoDetails()
        {
            AnsiConsole.MarkupLine("this is where the user will specify the download ig");
            Console.ReadKey();
        }
    }
}
