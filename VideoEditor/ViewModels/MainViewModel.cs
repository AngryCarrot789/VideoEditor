using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VideoEditor.Timeline;
using VideoEditor.Timeline.Controls.PropertiesControls;
using VideoEditor.Timeline.Controls.PropertiesControls.ViewModels;
using VideoEditor.Timeline.Controls.TimelineControls;
using VideoEditor.Timeline.Controls.TimelineControls.ViewModels;
using VideoEditor.Timeline.Views;
using VideoEditor.Timeline.Views.ViewModels;
using VideoEditor.Utilities;

namespace VideoEditor.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ClipSourceCollectionViewModel _clipSources;
        public ClipSourceCollectionViewModel ClipSources
        {
            get => _clipSources;
            set => RaisePropertyChanged(ref _clipSources, value);
        }
        private ClipSourcePropertiesCollectionViewModel _clipSourcesProps;
        public ClipSourcePropertiesCollectionViewModel ClipSourcesProperties
        {
            get => _clipSourcesProps;
            set => RaisePropertyChanged(ref _clipSourcesProps, value);
        }

        public MainViewModel()
        {
            ClipSources = new ClipSourceCollectionViewModel();
            ClipSourcesProperties = new ClipSourcePropertiesCollectionViewModel();

            AddNewVideo();
        }

        public void AddNewVideo()
        {
            TVideoAudioControl tVidAudio = new TVideoAudioControl();
            TVideoSourceControl tVideo = new TVideoSourceControl();
            TAudioSourceControl tAudio = new TAudioSourceControl();

            tVidAudio.TVideoAudio.AddVideoLayer(tVideo);
            tVidAudio.TVideoAudio.AddAudioLayer(tAudio);

            TVideoAudioPropertiesControl tVidAudioProps = new TVideoAudioPropertiesControl();
            TVideoSourcePropertiesControl tVideoProps = new TVideoSourcePropertiesControl();
            TAudioSourcePropertiesControl tAudioProps = new TAudioSourcePropertiesControl();

            tVidAudioProps.TVideoAudio.AddVideoLayer(tVideoProps);
            tVidAudioProps.TVideoAudio.AddAudioLayer(tAudioProps);


            ClipSources.AddClip(tVidAudio);
            ClipSourcesProperties.AddClip(tVidAudioProps);

        }
    }
}
