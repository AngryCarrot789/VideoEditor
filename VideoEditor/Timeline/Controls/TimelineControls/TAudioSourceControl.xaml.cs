using System.Windows.Controls;
using VideoEditor.Timeline.Controls.TimelineControls.ViewModels;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    /// <summary>
    /// An audio clip, displaying audio data
    /// </summary>
    public partial class TAudioSourceControl : UserControl
    {
        public TAudioSourceViewModel TAudio
        {
            get => this.DataContext as TAudioSourceViewModel;
            set => this.DataContext = value;
        }

        public TAudioSourceControl()
        {
            InitializeComponent();
            TAudio = new TAudioSourceViewModel();
        }
    }
}
