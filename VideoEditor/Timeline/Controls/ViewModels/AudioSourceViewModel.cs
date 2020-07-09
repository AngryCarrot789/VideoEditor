using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoEditor.Timeline.Controls.PropertiesControls;
using VideoEditor.Timeline.Controls.TimelineControls;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.ViewModels
{
    public class AudioSourceViewModel : BaseViewModel
    {
        public TAudioSourceViewModel Audio { get; set; }
        public TAudioSourcePropertiesViewModel AudioProperties { get; set; }

        public AudioSourceViewModel()
        {
            Audio = new TAudioSourceViewModel()
            {
                AudioSource = this
            };

            AudioProperties = new TAudioSourcePropertiesViewModel()
            {
                AudioSource = this
            };
        }
    }
}
