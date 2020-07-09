using System.Windows.Controls;
using VideoEditor.Timeline.Controls.PropertiesControls.ViewModels;

namespace VideoEditor.Timeline.Controls.PropertiesControls
{
    /// <summary>
    /// A layer containing 2 collections of 
    /// <see cref="TVideoSourcePropertiesControl"/>s and
    /// <see cref="TAudioSourcePropertiesControl"/>
    /// </summary>
    public partial class TVideoAudioPropertiesControl : UserControl
    {
        public TVideoAudioPropertiesViewModel TVideoAudio
        {
            get => this.DataContext as TVideoAudioPropertiesViewModel;
            set => this.DataContext = value;
        }

        public TVideoAudioPropertiesControl()
        {
            InitializeComponent();
            TVideoAudio = new TVideoAudioPropertiesViewModel();
        }
    }
}
