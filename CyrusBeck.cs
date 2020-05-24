using System;
using System.Linq;
using System.Collections.Generic;

namespace CyrusBeckLineClipping
{
    public class CyrusBeck
    {
        public enum CyrusBeckResult
        { 
            DoesNotIntersect,
            NotTrimmed,
            StartTrimmed,
            EndTrimmed,
            StartAndEndTrimmed
        }
    
        // Converted from c++ code at
        // https://www.geeksforgeeks.org/line-clipping-set-2-cyrus-beck-algorithm/
        public static bool LineClipping(List<Vector3> vertices, Vector3 startVector, Vector3 endVector, out Vector3 trimmedStartVector, out Vector3 trimmedEndVector, out CyrusBeckResult results)
        {
            List<Vector3> normals = new List<Vector3>();

            // Calculating the normals 
            for (int i = 0; i < vertices.Count; i++)
            {
                normals.Add(new Vector3(
                    vertices[i].Y - vertices[(i + 1) % vertices.Count].Y,
                    vertices[(i + 1) % vertices.Count].X - vertices[i].X,
                    0));
            }

            // Calculating P1 - P0 
            Vector3 P1_P0 = endVector - startVector;

            // Initializing all values of P0 - PEi 
            List<Vector3> P0_PEi = new List<Vector3>();


            // Calculating the values of P0 - PEi for all edges 
            for (int i = 0; i < vertices.Count; i++)
            {

                // Calculating PEi - P0, so that the denominator won't have to multiply by -1 while calculating 't' 
                P0_PEi.Add(new Vector3(vertices[i].X - startVector.X, vertices[i].Y - startVector.Y, 0));
            }

            List<double> numerator = new List<double>();
            List<double> denominator = new List<double>();

            // Calculating the numerator and denominators 
            // using the dot function 
            for (int i = 0; i < vertices.Count; i++)
            {
                numerator.Add(dotProduct(normals[i], P0_PEi[i]));
                denominator.Add(dotProduct(normals[i], P1_P0));
            }

            // Initializing the 't' values dynamically 
            List<double> t = new List<double>();

            // Making two vectors called 't entering' 
            // and 't leaving' to group the 't's 
            // according to their denominators 
            List<double> tEntering = new List<double>();
            List<double> tLeaving = new List<double>();

            // Calculating 't' and grouping them accordingly 
            for (int i = 0; i < vertices.Count; i++)
            {
                if (denominator[i] == 0)
                    t.Add(numerator[i]);
                else
                    t.Add(numerator[i] / denominator[i]);

                if (denominator[i] >= 0)
                    tEntering.Add(t[i]);
                else
                    tLeaving.Add(t[i]);
            }

            // Initializing the final two values of 't' 
            double tEnteringMax;
            double tLeavingMin;

            // Taking the max of all 'tE' and 0, so pushing 0 
            tEntering.Add(0);
            tEnteringMax = tEntering.Max();

            // Taking the min of all 'tL' and 1, so pushing 1 
            tLeaving.Add(1);
            tLeavingMin = tLeaving.Min();

            // Entering 't' value cannot be greater than exiting 't' value, hence, this is the case when the line 
            // is completely outside 
            if (tEnteringMax > tLeavingMin)
            {
                trimmedStartVector = new Vector3();
                trimmedEndVector = new Vector3();
                results = CyrusBeckResult.DoesNotIntersect;
                return false;
            }

            // Calculating the coordinates in terms of the trimmed x and y 
            trimmedStartVector = new Vector3(startVector.X + P1_P0.X * tEnteringMax, startVector.Y + P1_P0.Y * tEnteringMax, 0);
            trimmedEndVector = new Vector3(startVector.X + P1_P0.X * tLeavingMin, startVector.Y + P1_P0.Y * tLeavingMin, 0);

            bool StartTrimmed = IsSame(startVector, trimmedStartVector) ? false : true;
            bool EndTrimmed = IsSame(endVector, trimmedEndVector) ? false : true;

            if (StartTrimmed && EndTrimmed)
                results = CyrusBeckResult.StartAndEndTrimmed;
            else if (StartTrimmed)
                results = CyrusBeckResult.StartTrimmed;
            else if (EndTrimmed)
                results = CyrusBeckResult.EndTrimmed;
            else
                results = CyrusBeckResult.NotTrimmed;
            return true;
        }

        private static bool IsSame(Vector3 p1, Vector3 p2)
        {
            if (IsSame(p1.X, p2.X) == false)
                return false;
            if (IsSame(p1.Y, p2.Y) == false)
                return false;
            if (IsSame(p1.Z, p2.Z) == false)
                return false;
            return true;
        }

        private static bool IsSame(double a, double b)
        {
            // Compare to 5 decimal points
            return Math.Abs(a - b) < 0.00001;
        }


        private static double dotProduct(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        private static Vector3 crossProduct(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

    }
}