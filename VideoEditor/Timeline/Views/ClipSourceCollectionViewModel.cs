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
    public class ClipSourceCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<object> ClipsSources { get; set; }

        public ClipSourceCollectionViewModel()
        {
            ClipsSources = new ObservableCollection<object>();
        }

        public void AddClip(object clip)
        {
            ClipsSources.Add(clip);
        }
    }
}
