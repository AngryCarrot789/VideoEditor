using System.Windows.Controls;
using VideoEditor.Timeline.Controls.TimelineControls.ViewModels;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    /// <summary>
    /// A layer containing 2 collections of 
    /// <see cref="TVideoSourceControl"/>s and
    /// <see cref="TAudioSourceControl"/>
    /// </summary>
    public partial class TVideoAudioControl : UserControl
    {
        public TVideoAudioViewModel TVideoAudio
        {
            get => this.DataContext as TVideoAudioViewModel;
            set => this.DataContext = value;
        }

        public TVideoAudioControl()
        {
            InitializeComponent();
            TVideoAudio = new TVideoAudioViewModel();
        }
    }
}
