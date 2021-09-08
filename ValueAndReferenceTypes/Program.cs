using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int XP, int YP)
        {
            X = XP;
            Y = YP;
        }

        public void Increment()
        {
            X++; Y++;
        }
        public void Decrement()
        {
            X--; Y--;
        }
        public void Display()
        {
            Console.WriteLine("X={0}, Y={1}", X, Y);
        }
    }
    public class PointRef
    {
        public int X;
        public int Y;

        public PointRef(int XP, int YP)
        {
            X = XP;
            Y = YP;
        }

        public void Increment()
        {
            X++; Y++;
        }
        public void Decrement()
        {
            X--; Y--;
        }
        public void Display()
        {
            Console.WriteLine("X={0}, Y={1}", X, Y);
        }
    }
    public class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo(string info)
        {
            InfoString = info;
        }
    }
    public struct Rectangle
    {
        public ShapeInfo RectInfo;
        public int RectTop, RectLeft, RectBottom, RectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);//
            RectTop = top; RectLeft = left;
            RectBottom = bottom; RectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Left = {2}, Bottom = {3}, Right = {4}",
                RectInfo.InfoString, RectTop, RectLeft, RectBottom, RectRight);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assigning calue types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
            Console.WriteLine();

            PointRef pref1 = new PointRef(10, 10);
            PointRef pref2 = pref1;
            pref1.Display();
            pref2.Display();

            pref1.X = 100;
            Console.WriteLine("\n=> Changed pref1.X\n");
            pref1.Display();
            pref2.Display();

            Console.WriteLine();
            ValueTypeContainingRefType();
            Console.WriteLine();
        }
        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("=>Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            Console.WriteLine("=>Assigning r2 to r1");
            Rectangle r2 = r1;
            Console.WriteLine("=>Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            r1.Display();
            r2.Display();
        }
    }
}
