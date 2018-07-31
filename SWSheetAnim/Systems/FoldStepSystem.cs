using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    class FoldStepSystem : StepSystem
    {
        FoldStep Step;
        FoldSystem FoldSystem;

        public FoldStepSystem(FoldStep foldStep)
        {
            this.Step = foldStep;
            FoldSystem = new FoldSystem(foldStep.Fold);
        }

        public override double GetDuration()
        {
            return Step.Duration;
        }

        public override void SetPlayback(double progress)
        {
            if(Step.IsFoldBack)
            {
                if(progress > 0.5)
                {
                    progress = 1 - progress;
                }
            }
            double parameter = Step.StartValue + progress * (Step.EndValue - Step.StartValue);
            FoldSystem.SetValue(parameter); // fold system accepts a radian value
            FoldSystem.RefreshScene();
        }
    }
}
