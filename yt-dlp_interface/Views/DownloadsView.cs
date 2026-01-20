using Spectre.Console;
using yt_dlp_interface.Controllers;
using yt_dlp_interface.Models;

namespace yt_dlp_interface.Views
{
    public interface IDownloadsView
    {
        DownloadDto GetVideoDetails();
    }

    public class DownloadsView : IDownloadsView
    {
        public DownloadDto GetVideoDetails()
        {
            var download = new DownloadDto();
            AnsiConsole.MarkupLine("[green]Enter the URL of the video you would like to save in .wav format::[/]\n");
            download.Url = Console.ReadLine();

            return (download);
        }
    }
}
