using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    public class Vector
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Z { get; set; } = 0;

        public Vector(Vector v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public Vector(double[] points)
        {
            X = points[0];
            Y = points[1];
            Z = points[2];
        }

        public double[] ToPoints()
        {
            return new double[] { X, Y, Z };
        }

        public static Vector operator +(Vector t1, Vector t2)
        {
            return new Vector(new double[] { t1.X + t2.X, t1.Y + t2.Y, t1.Z + t2.Z });
        }

        public static Vector operator -(Vector t1, Vector t2)
        {
            return new Vector(new double[] { t1.X - t2.X, t1.Y - t2.Y, t1.Z - t2.Z });
        }

        public static Vector operator *(Vector t1, double d)
        {
            return new Vector(new double[] { t1.X * d, t1.Y * d, t1.Z * d });
        }

        public static Vector operator *(double d, Vector t1)
            =>  t1 * d;
    }
}
