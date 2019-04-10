using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSheetAnim.Components
{
    [Serializable()]
    public class Transform
    {
        public double x { get; set; } = 0;
        public double y { get; set; } = 0;
        public double z { get; set; } = 0;
        public double pitch { get; set; }
        public double yaw { get; set; }
        public double roll { get; set; }
        public double scale { get; set; } = 1;

        public Transform(double[] m)
        {
            x = m[9];
            y = m[10];
            z = m[11];
            yaw = RadianToDegree(Math.Atan2(m[3], m[0]));
            pitch = RadianToDegree(Math.Atan2(-m[6], Math.Sqrt(m[7] * m[7] + m[8] * m[8])));
            roll = RadianToDegree(Math.Atan2(m[7], m[8]));
        }

        public Transform(Transform t)
        {
            x = t.x;
            y = t.y;
            z = t.z;
            yaw = t.yaw;
            pitch = t.pitch;
            roll = t.roll;
            scale = t.scale;
        }

        public double[] ToMatrix()
        {
            double a = DegreeToRadian(yaw);
            double b = DegreeToRadian(pitch);
            double g = DegreeToRadian(roll);
            double[] m = new double[16]{
                Math.Cos(a)*Math.Cos(b),    Math.Cos(a)*Math.Sin(b)*Math.Sin(g) - Math.Sin(a)*Math.Cos(g),    Math.Cos(a)*Math.Sin(b)*Math.Cos(g) + Math.Sin(a)*Math.Sin(g),
                Math.Sin(a)*Math.Cos(b),    Math.Sin(a)*Math.Sin(b)*Math.Sin(g) + Math.Cos(a)*Math.Cos(g),    Math.Sin(a)*Math.Sin(b)*Math.Cos(g) - Math.Cos(a)*Math.Sin(g),
               -Math.Sin(b),                Math.Cos(b)*Math.Sin(g),                                          Math.Cos(b)*Math.Cos(g),
               x, y, z,
               scale,
               0, 0, 0
            };


            return m;
        }

        public static Transform operator +(Transform t1, Transform t2)
        {
            Transform t3 = new Transform(t1);
            t3.x += t2.x;
            t3.y += t2.y;
            t3.z += t2.z;
            t3.pitch += t2.pitch;
            t3.yaw += t2.yaw;
            t3.roll += t2.roll;
            t3.scale += t2.scale;
            return t3;
        }

        public static Transform operator *(Transform t1, double d)
        {
            Transform t3 = new Transform(t1);
            t3.x *= d;
            t3.y *= d;
            t3.z *= d;
            t3.pitch *= d;
            t3.yaw *= d;
            t3.roll *= d;
            t3.scale *= d;
            return t3;
        }

        public static Transform operator *(double d, Transform t1)
            => t1 * d;

        public static Transform operator -(Transform t1, Transform t2)
            => t2 * (-1) + t1;

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}
