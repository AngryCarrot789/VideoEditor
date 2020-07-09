using VideoEditor.Timeline.Controls.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    public class TAudioSourceViewModel : BaseViewModel
    {
        private AudioSourceViewModel _audioSource;
        public AudioSourceViewModel AudioSource
        {
            get => _audioSource;
            set => RaisePropertyChanged(ref _audioSource, value);
        }

        public TAudioSourceViewModel()
        {

        }
    }
}
