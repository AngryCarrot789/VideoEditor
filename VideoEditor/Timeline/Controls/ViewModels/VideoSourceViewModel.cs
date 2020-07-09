using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoEditor.Timeline.Controls.TimelineControls;
using VideoEditor.Utilities;

namespace VideoEditor.Timeline.Controls.ViewModels
{
    public class VideoSourceViewModel : BaseViewModel
    {
        public TVideoSourceViewModel Video { get; set; }
        public TVideoSourceViewModel VideoProperties { get; set; }

        public VideoSourceViewModel()
        {
            Video = new TVideoSourceViewModel()
            {
                VideoSource = this
            };

            VideoProperties = new TVideoSourceViewModel()
            {
                VideoSource = this
            };
        }
    }
}
