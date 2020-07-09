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
using VideoEditor.Timeline.Controls.PropertiesControls;
using VideoEditor.ViewModels;

namespace VideoEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel MainView
        {
            get => this.DataContext as MainViewModel;
            set => this.DataContext = value;
        }
        public MainWindow()
        {
            InitializeComponent();
            MainView = new MainViewModel();
        }
    }
}
