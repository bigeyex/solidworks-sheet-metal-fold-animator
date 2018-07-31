using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorks;
using SwConst;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    public class FoldSystem
    {
        Fold Fold;
        Feature SWFeature;
        Dimension SWDim;

        public FoldSystem(Fold f)
        {
            this.Fold = f;
            Component2 swComp = SWEngine.Instance.GetComponentByName(f.PartName);
            SWFeature = swComp.FeatureByName(f.Name);
            SWDim = SWFeature.Parameter("D4");
        }

        public void SetValue(double value)
        {
            double targetValue = Math.PI * value / 180.0;
            if (targetValue <= 0.01)
            {
                targetValue = 0.01;
            }
            SWDim.SystemValue = targetValue;
        }

        public double GetValue(double value)
        {
            return SWDim.SystemValue * 180 / Math.PI;
        }

        public void RefreshScene()
        {
            SWEngine.Instance.RefreshScene();
        }
    }
}
