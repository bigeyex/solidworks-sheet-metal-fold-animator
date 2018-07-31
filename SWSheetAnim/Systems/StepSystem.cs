using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    public delegate void FrameBuilder(Bitmap frame);

    abstract class StepSystem
    {
        const double FrameLength = 1000 / 24;

        public abstract void SetPlayback(double progress);
        public abstract double GetDuration();

        public void SetPlaybackTime(double seconds)
        {
            if(seconds <= 0)
            {
                SetPlayback(0);
            }
            else if(seconds > GetDuration())
            {
                SetPlayback(1);
            }
            else
            {
                SetPlayback(seconds / GetDuration());
            }
        }

        public static StepSystem FromStep(IStep step)
        {
            if(step is FoldStep)
            {
                return new FoldStepSystem((FoldStep)step);
            }
            else
            {
                return new TransformStepSystem((TransformStep)step);
            }
        }
    }
}
