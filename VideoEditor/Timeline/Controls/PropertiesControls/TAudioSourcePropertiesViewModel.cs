using VideoEditor.Timeline.Controls.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.PropertiesControls
{
    public class TAudioSourcePropertiesViewModel : BaseViewModel
    {
        private AudioSourceViewModel _videoSource;
        public AudioSourceViewModel AudioSource
        {
            get => _videoSource;
            set => RaisePropertyChanged(ref _videoSource, value);
        }

        public TAudioSourcePropertiesViewModel()
        {

        }
    }
}
