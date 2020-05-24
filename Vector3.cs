using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrusBeckLineClipping
{
    public class Vector3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3()
        {            
        }

        public Vector3(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        // Adds two vectors.
        public static Vector3 operator +(Vector3 a, Vector3 b) { return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z); }
        // Subtracts one vector from another.
        public static Vector3 operator -(Vector3 a, Vector3 b) { return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z); }
        // Negates a vector.
        public static Vector3 operator -(Vector3 a) { return new Vector3(-a.X, -a.Y, -a.Z); }
        // Multiplies a vector by a number.
        public static Vector3 operator *(Vector3 a, float d) { return new Vector3(a.X * d, a.Y * d, a.Z * d); }
        // Multiplies a vector by a number.
        public static Vector3 operator *(float d, Vector3 a) { return new Vector3(a.X * d, a.Y * d, a.Z * d); }
    }
}
