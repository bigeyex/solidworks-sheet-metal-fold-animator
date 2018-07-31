using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorks;
using SwConst;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    public class PartSystem
    {
        Part Part;
        Component2 SWComp;

        public PartSystem(Part part)
        {
            Part = part;
            SWComp = SWEngine.Instance.GetComponentByName(part.Name);

            MathTransform mt = SWComp.Transform2;
            double[] m = mt.ArrayData;
            Transform t = new Transform(m);
        }

        public void SetTransform(Transform t)
        {
            SWComp.Transform2 = SWEngine.Instance.GetUtility().CreateTransform(t.ToMatrix());
            //SWComp.Transform2.ArrayData = t;
        }

        public Transform GetTransform()
        {
            return new Transform(SWComp.Transform2.ArrayData);
        }

        public void RefreshScene()
        {
            SWEngine.Instance.RefreshMove();
        }

        public Fold[] GetFolds()
        {
            return SWEngine.Instance.GetFoldsFromComponent(SWComp);
        }
    }
}
