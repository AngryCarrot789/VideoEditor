using System.Windows.Controls;
using VideoEditor.Timeline.Controls.TimelineControls.ViewModels;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    /// <summary>
    /// A video clip, displaying some of the frames of the video
    /// </summary>
    public partial class TVideoSourceControl : UserControl
    {
        public TVideoSourceViewModel TVideo
        {
            get => this.DataContext as TVideoSourceViewModel;
            set => this.DataContext = value;
        }

        public TVideoSourceControl()
        {
            InitializeComponent();
            TVideo = new TVideoSourceViewModel();
        }
    }
}
