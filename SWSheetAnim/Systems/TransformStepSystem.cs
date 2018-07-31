using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    class TransformStepSystem : StepSystem
    {
        TransformStep Step;
        PartSystem PartSystem;

        public TransformStepSystem(TransformStep step)
        {
            Step = step;
            PartSystem = new PartSystem(step.Part);

        }

        public override double GetDuration()
        {
            return Step.Duration;
        }

        public override void SetPlayback(double progress)
        {
            PartSystem.SetTransform(Step.StartTransform + progress * (Step.EndTransform - Step.StartTransform));
            PartSystem.RefreshScene();
        }
    }
}
