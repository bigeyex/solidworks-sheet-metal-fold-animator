using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    public class CameraPosition
    {
        public Vector Translation;
        public Transform Orientation;
        public double Scale;

        public CameraPosition(CameraPosition cp)
        {
            Translation = new Vector(cp.Translation);
            Orientation = new Transform(cp.Orientation);
            Scale = cp.Scale;
        }

        public CameraPosition(Vector translation, Transform orientation, double scale)
        {
            Translation = translation;
            Orientation = orientation;
            Scale = scale;
        }

        public static CameraPosition operator +(CameraPosition t1, CameraPosition t2)
            => new CameraPosition(t1.Translation + t2.Translation, t1.Orientation + t2.Orientation, t1.Scale + t2.Scale);

        public static CameraPosition operator -(CameraPosition t1, CameraPosition t2)
            => new CameraPosition(t1.Translation - t2.Translation, t1.Orientation - t2.Orientation, t1.Scale - t2.Scale);

        public static CameraPosition operator *(CameraPosition t1, double d)
            => new CameraPosition(t1.Translation * d, t1.Orientation * d, t1.Scale * d);

        public static CameraPosition operator *(double d, CameraPosition t1)
            => t1 * d;
    }
}
