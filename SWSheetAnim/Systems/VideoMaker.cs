using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.FFMPEG;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    class VideoMaker
    {
        VideoFileWriter Writer;

        public VideoMaker(string fileName)
        {
            Writer = new VideoFileWriter();
            Bitmap screenshot = SWEngine.Instance.GetSnapshot();
            int width = screenshot.Width % 2 == 0 ? screenshot.Width : screenshot.Width + 1;
            int height = screenshot.Height % 2 == 0 ? screenshot.Height : screenshot.Height + 1;
            Writer.Open(fileName, width, height, 25, VideoCodec.MPEG4, 1000000);
        }

        public void AddFrame(Bitmap frame)
        {
            // convert bitmap to 32bpppargb
            Bitmap clone = new Bitmap(frame.Width, frame.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics gr = Graphics.FromImage(clone))
            {
                gr.DrawImage(frame, new Rectangle(0, 0, clone.Width, clone.Height));
            }

            Writer.WriteVideoFrame(clone);
        }

        public void AddSnapshot()
        {
            AddFrame(SWEngine.Instance.GetSnapshot());
        }

        public void AddStep(IStep step)
        {
            StepSystem system = StepSystem.FromStep(step);
            for (int t = 0; t < (int)(step.Duration * 25); t++) {
                system.SetPlaybackTime(((double)t) / 25);
                AddSnapshot();
            }
            system.SetPlayback(1);  // 防止最后一帧未到位
            AddSnapshot();
            for (int t=0; t<(int)(step.WaitTime * 25); t++)     // 录制其后的等待帧
            {
                AddSnapshot();
            }
        }

        public void Close()
        {
            Writer.Close();
            Writer = null;
        }
    }
}
