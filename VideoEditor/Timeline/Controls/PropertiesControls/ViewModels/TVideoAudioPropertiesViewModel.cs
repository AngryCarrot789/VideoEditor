using System.Collections.ObjectModel;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.PropertiesControls.ViewModels
{
    public class TVideoAudioPropertiesViewModel : BaseViewModel
    {
        public ObservableCollection<TVideoSourcePropertiesControl> VideoPropertiesLayers { get; set; }
        public ObservableCollection<TAudioSourcePropertiesControl> AudioPropertiesLayers { get; set; }

        public TVideoAudioPropertiesViewModel()
        {
            VideoPropertiesLayers = new ObservableCollection<TVideoSourcePropertiesControl>();
            AudioPropertiesLayers = new ObservableCollection<TAudioSourcePropertiesControl>();
        }

        public void AddVideoLayer(TVideoSourcePropertiesControl vidSrc)
        {
            VideoPropertiesLayers.Add(vidSrc);
        }

        public void AddAudioLayer(TAudioSourcePropertiesControl vidSrc)
        {
            AudioPropertiesLayers.Add(vidSrc);
        }
    }
}
