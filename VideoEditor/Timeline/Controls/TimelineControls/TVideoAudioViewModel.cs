using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.TimelineControls
{
    public class TVideoAudioViewModel : BaseViewModel
    {
        public ObservableCollection<TVideoSourceControl> VideoLayers { get; set; }
        public ObservableCollection<TAudioSourceControl> AudioLayers { get; set; }

        public TVideoAudioViewModel()
        {
            VideoLayers = new ObservableCollection<TVideoSourceControl>();
            AudioLayers = new ObservableCollection<TAudioSourceControl>();
        }
    }
}
