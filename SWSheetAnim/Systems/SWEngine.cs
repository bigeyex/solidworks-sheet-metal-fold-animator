using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SldWorks;
using SwConst;
using SWSheetAnim.Components;

namespace SWSheetAnim.Systems
{
    public sealed class SWEngine
    {
        // Singleton
        private static readonly Lazy<SWEngine> lazy =
            new Lazy<SWEngine>(() => new SWEngine());

        public static SWEngine Instance {  get { return lazy.Value;  } }

        // members

        SldWorks.SldWorks swApp;
        SldWorks.IModelDoc2 swModel;
        AssemblyDoc asmDoc;

        private SWEngine() {
            swApp = new SldWorks.SldWorks();

            swModel = swApp.IActiveDoc2;
            asmDoc = (AssemblyDoc)swModel;
        }

        ~SWEngine()
        {
            swApp = null;
        }

        public MathUtility GetUtility()
        {
            return swApp.GetMathUtility();
        }

        public Part[] GetParts()
        {
            Component2[] components = ((object[])asmDoc.GetComponents(false)).Select(p => (Component2)p).ToArray() ;
            return components.Select(component => new Part(component.Name)).ToArray();
        }

        public Fold[] GetFoldsFromComponent(Component2 comp)
        {
            object vBodyInfo;
            string compName = comp.Name;
            object[] bodies = comp.GetBodies3((int)swBodyType_e.swAllBodies, out vBodyInfo);
            List<Fold> foldList = new List<Fold>();

            foreach (Object body in bodies)
            {
                Body2 swBody = (Body2)body;
                object[] features = swBody.GetFeatures();

                foreach (Feature feature in features)
                {
                    if (feature.GetTypeName2().Equals("SM3dBend"))
                    {
                        foldList.Add(new Fold(feature.Name, compName));
                    }

                }
            }

            return foldList.ToArray();
        }

        public void RefreshScene()
        {
            swModel.EditRebuild3();
        }

        public void RefreshMove()
        {
            swModel.Rebuild((int)swRebuildOptions_e.swUpdateMates);
            swModel.GraphicsRedraw2();
        }

        public void RefreshView()
        {
            swModel.GraphicsRedraw2();
        }

        public CameraPosition GetCameraPosition()
        {
            ModelView mv = swModel.ActiveView;
            return new CameraPosition(
                    new Vector(mv.Translation3.ArrayData),
                    new Transform(mv.Orientation3.ArrayData),
                    mv.Scale2
                );
        }

        public void SetCameraPosition(CameraPosition cp)
        {
            ModelView mv = swModel.ActiveView;
            mv.Translation3 = GetUtility().CreateVector(cp.Translation.ToPoints());
            mv.Orientation3 = GetUtility().CreateTransform(cp.Orientation.ToMatrix());
            mv.Scale2 = cp.Scale;
        }

        public Component2 GetComponentByName(string compName)
        {
            return asmDoc.GetComponentByName(compName);
        }

        public Bitmap GetSnapshot()
        {
            const int swCommands_ScreenCapture = 604;
            swApp.RunCommand((int)swCommands_ScreenCapture, "");
            return (Bitmap)Clipboard.GetImage();
        }
        
    }
}
