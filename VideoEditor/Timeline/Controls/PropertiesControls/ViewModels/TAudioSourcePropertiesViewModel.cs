using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.PropertiesControls.ViewModels
{
    public class TAudioSourcePropertiesViewModel : BaseViewModel
    {
        private double _audioVolume;
        public double AudioVolume
        {
            get => _audioVolume;
            set => RaisePropertyChanged(ref _audioVolume, value);
        }

        public TAudioSourcePropertiesViewModel()
        {

        }
    }
}
