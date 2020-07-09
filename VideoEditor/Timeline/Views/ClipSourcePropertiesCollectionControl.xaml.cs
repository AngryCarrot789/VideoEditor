using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VideoEditor.Timeline.Views.ViewModels;

namespace VideoEditor.Timeline.Views
{
    /// <summary>
    /// Interaction logic for ClipSourcePropertiesCollectionControl.xaml
    /// </summary>
    public partial class ClipSourcePropertiesCollectionControl : UserControl
    {
        public ClipSourcePropertiesCollectionViewModel TSourcePropertiesCollection
        {
            get => this.DataContext as ClipSourcePropertiesCollectionViewModel;
            set => this.DataContext = value;
        }

        public ClipSourcePropertiesCollectionControl()
        {
            InitializeComponent();
        }
    }
}
