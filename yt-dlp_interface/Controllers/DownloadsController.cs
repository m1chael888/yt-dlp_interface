using yt_dlp_interface.Views;

namespace yt_dlp_interface.Controllers
{
    public interface IDownloadsController
    {
        void CallDownloadsView();
        void CallDownloadsService();
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

        public void CallDownloadsService()
        {

        }
    }
}