using System.Collections.ObjectModel;
using System.Security.Permissions;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.TimelineControls.ViewModels
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

        public void AddVideoLayer(TVideoSourceControl vidSrc)
        {
            VideoLayers.Add(vidSrc);
        }

        public void AddAudioLayer(TAudioSourceControl vidSrc)
        {
            AudioLayers.Add(vidSrc);
        }
    }
}
