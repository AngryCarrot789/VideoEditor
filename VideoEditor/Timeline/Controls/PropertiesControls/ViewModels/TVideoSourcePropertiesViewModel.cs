using System.Drawing.Text;
using System.Windows.Media.Converters;
using VideoEditor.Timeline.Controls.TimelineControls.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.PropertiesControls.ViewModels
{
    public class TVideoSourcePropertiesViewModel : BaseViewModel
    {
        private double _videoOpacity;
        public double VideoOpacity
        {
            get => _videoOpacity;
            set => RaisePropertyChanged(ref _videoOpacity, value);
        }

        public TVideoSourcePropertiesViewModel()
        {

        }
    }
}
