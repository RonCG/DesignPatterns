using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point DeepCopy()
        {
            Point copy = new Point(this.X, this.Y);        
            return copy;
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            Line copy = new Line(this.Start.DeepCopy(), this.End.DeepCopy());          
            return copy;
        }

        public override string ToString()
        {
            return $"Start-X: {Start.X}, Start-Y: {Start.Y}, End-X: {End.X}, End-Y: {End.Y}";
        }
    }
}
