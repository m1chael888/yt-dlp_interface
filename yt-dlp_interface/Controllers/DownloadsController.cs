using yt_dlp_interface.Views;
using yt_dlp_interface.Models;

namespace yt_dlp_interface.Controllers
{
    public interface IDownloadsController
    {
        void CallDownloadsView();
        void CallDownloadsService(DownloadDto Dto);
    }

    public class DownloadsController : IDownloadsController
    {
        private readonly IDownloadsView _downloadsView;

        public DownloadsController(IDownloadsView downloadsView)
        {
            _downloadsView = downloadsView;
        }

        public void CallDownloadsView()
        {
            _downloadsView.GetVideoDetails();
        }

        public void CallDownloadsService(DownloadDto Dto)
        {
            
        }
    }
}