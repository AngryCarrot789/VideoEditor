using VideoEditor.Timeline.Controls.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.PropertiesControls
{
    public class TVideoSourcePropertiesViewModel : BaseViewModel
    {
        private VideoSourceViewModel _videoSource;
        public VideoSourceViewModel VideoSource
        {
            get => _videoSource;
            set => RaisePropertyChanged(ref _videoSource, value);
        }

        public TVideoSourcePropertiesViewModel()
        {

        }
    }
}
