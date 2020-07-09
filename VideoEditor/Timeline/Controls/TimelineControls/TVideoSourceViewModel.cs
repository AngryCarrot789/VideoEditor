using VideoEditor.Timeline.Controls.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    public class TVideoSourceViewModel : BaseViewModel
    {
        private VideoSourceViewModel _videoSource;
        public VideoSourceViewModel VideoSource
        {
            get => _videoSource;
            set => RaisePropertyChanged(ref _videoSource, value);
        }

        public TVideoSourceViewModel()
        {

        }
    }
}
