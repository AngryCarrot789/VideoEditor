using System.Collections.ObjectModel;
using VideoEditor.Timeline.Controls.PropertiesControls;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Views.ViewModels
{
    public class ClipSourcePropertiesCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<TVideoAudioPropertiesControl> ClipPropertieSources { get; set; }

        public ClipSourcePropertiesCollectionViewModel()
        {
            ClipPropertieSources = new ObservableCollection<TVideoAudioPropertiesControl>();
        }

        public void AddClip(TVideoAudioPropertiesControl clip)
        {
            ClipPropertieSources.Add(clip);
        }
    }
}
