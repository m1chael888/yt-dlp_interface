using yt_dlp_interface.Models;

namespace yt_dlp_interface.Services
{
    public interface IDownloadsService
    {
        bool ValidateUrl(DownloadDto Dto);
        void Download(DownloadDto Dto);
    }
    public class DownloadsService : IDownloadsService
    {
        public bool ValidateUrl(DownloadDto Dto)
        {
            return true; // TODO: only if valid
        }

        public void Download(DownloadDto Dto)
        {
            // 
        }
    }
}
