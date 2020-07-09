using System.Windows.Controls;
using VideoEditor.Timeline.Controls.PropertiesControls.ViewModels;

namespace VideoEditor.Timeline.Controls.PropertiesControls
{
    /// <summary>
    /// An audio clip
    /// </summary>
    public partial class TAudioSourcePropertiesControl : UserControl
    {
        public TAudioSourcePropertiesViewModel TAudioProperties
        {
            get => this.DataContext as TAudioSourcePropertiesViewModel;
            set => this.DataContext = value;
        }

        public TAudioSourcePropertiesControl()
        {
            InitializeComponent();
            TAudioProperties = new TAudioSourcePropertiesViewModel();
        }
    }
}
