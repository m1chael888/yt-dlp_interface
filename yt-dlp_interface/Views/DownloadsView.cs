using Spectre.Console;
using yt_dlp_interface.Controllers;
using yt_dlp_interface.Models;

namespace yt_dlp_interface.Views
{
    public interface IDownloadsView
    {
        void GetVideoDetails();
    }

    public class DownloadsView : IDownloadsView
    {
        private readonly IDownloadsController _downloadsController;

        public DownloadsView(IDownloadsController downloadsController)
        {
            _downloadsController = downloadsController;
        }

        public void GetVideoDetails()
        {
            var download = new DownloadDto();
            AnsiConsole.MarkupLine("[green]Enter the URL of the video you would like to download in .wav format::[/]");
            Console.ReadLine();
            download.Url = Console.ReadLine();


        }
    }
}
