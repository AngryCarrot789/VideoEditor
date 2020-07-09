using System.Collections.ObjectModel;
using VideoEditor.Timeline.Controls.TimelineControls;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Views.ViewModels
{
    public class ClipSourceCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<TVideoAudioControl> ClipsSources { get; set; }

        public ClipSourceCollectionViewModel()
        {
            ClipsSources = new ObservableCollection<TVideoAudioControl>();
        }

        public void AddClip(TVideoAudioControl clip)
        {
            ClipsSources.Add(clip);
        }
    }
}
