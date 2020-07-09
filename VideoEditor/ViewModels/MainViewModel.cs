using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoEditor.Timeline;
using VideoEditor.Timeline.Views;
using VideoEditor.Utilities;

namespace VideoEditor.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ClipSourceCollectionViewModel ClipSource { get; set; }
        public ClipSourcePropertiesCollectionViewModel ClipSourceProperties { get; set; }

        public MainViewModel()
        {
            ClipSource = new ClipSourceCollectionViewModel();
            ClipSourceProperties = new ClipSourcePropertiesCollectionViewModel();
        }
    }
}
