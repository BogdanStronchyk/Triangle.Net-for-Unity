﻿// -----------------------------------------------------------------------
// <copyright file="IPredicates.cs">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace TriangleNet
{
    using TriangleNet.Geometry;

    public interface IPredicates
    {
        float CounterClockwise(Point a, Point b, Point c);

        float InCircle(Point a, Point b, Point c, Point p);

        Point FindCircumcenter(Point org, Point dest, Point apex, ref float xi, ref float eta);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vert1"></param>
        /// <param name="vert2"></param>
        /// <param name="vert3"></param>
        /// <returns></returns>
        Point FindBarycenter(Vertex vert1, Vertex vert2, Vertex vert3);


        Point FindCircumcenter(Point org, Point dest, Point apex, ref float xi, ref float eta,
            float offconstant);
    }
}
