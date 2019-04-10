using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    class CameraStepSystem : StepSystem
    {
        CameraStep Step;

        public CameraStepSystem(CameraStep step)
        {
            Step = step;

        }

        public override double GetDuration()
        {
            return Step.Duration;
        }

        public override void SetPlayback(double progress)
        {
            SWEngine.Instance.SetCameraPosition(Step.StartPosition + progress * (Step.EndPosition - Step.StartPosition));
            SWEngine.Instance.RefreshView();
        }
    }
}
