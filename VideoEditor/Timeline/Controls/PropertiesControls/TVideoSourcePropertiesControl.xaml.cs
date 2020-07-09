using System.Windows.Controls;
using VideoEditor.Timeline.Controls.PropertiesControls.ViewModels;

namespace VideoEditor.Timeline.Controls.PropertiesControls
{
    /// <summary>
    /// A video clip
    /// </summary>
    public partial class TVideoSourcePropertiesControl : UserControl
    {
        public TVideoSourcePropertiesViewModel TVideoProperties
        {
            get => this.DataContext as TVideoSourcePropertiesViewModel;
            set => this.DataContext = value;
        }

        public TVideoSourcePropertiesControl()
        {
            InitializeComponent();
            TVideoProperties = new TVideoSourcePropertiesViewModel();
        }
    }
}
