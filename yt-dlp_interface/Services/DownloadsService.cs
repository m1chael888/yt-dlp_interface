using Spectre.Console;
using System.Management.Automation;
using yt_dlp_interface.Models;

namespace yt_dlp_interface.Services
{
    public interface IDownloadsService
    {
        bool ValidateUrl(DownloadDto Dto);
        string Download(DownloadDto Dto);
    }
    public class DownloadsService : IDownloadsService
    {
        public bool ValidateUrl(DownloadDto Dto)
        {
            return true; // TODO: only if valid
        }

        public string Download(DownloadDto Dto)
        {
            string dlWavScript = $"yt-dlp -f bestaudio --extract-audio --audio-format flac {Dto.Url}";

            using (var ps = PowerShell.Create())
            {
                ps.AddScript(@"cd C:\");
                ps.AddScript(dlWavScript);
                var output = ps.Invoke();

                if (output.Count > 0) return $"[green]Successfully downloaded {Dto.Url} =)[/]";
            }
            return "[red]Error!![/]";
        }
    }
}
