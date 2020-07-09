using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Views
{
    public class ClipSourcePropertiesCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<object> ClipPropertieSources { get; set; }

        public ClipSourcePropertiesCollectionViewModel()
        {
            ClipPropertieSources = new ObservableCollection<object>();
        }

        public void AddClip(object clip)
        {
            ClipPropertieSources.Add(clip);
        }
    }
}
