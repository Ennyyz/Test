using System;

namespace NapChongToanTu
{
    class Box
    {
        private double Length;
        private double Width;
        private double Height;

        public double Volumetric()
        {
            return Length * Width * Height;
        }
        public void AssignLength(double length)
        {
            Length = length;
        }
        public void AssignWidth(double width)
        {
            Width = width;
        }
        public void AssignHeight(double height)
        {
            Height = height;
        }

        public static Box operator +(Box a, Box b)
        {
            Box boxA = new Box();
            boxA.Length = a.Length + b.Length;
            boxA.Width = a.Width + b.Width;
            boxA.Height = a.Height + b.Height;
            return boxA;
        }
    }
    class TryToCalculate
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volumetric = 0.0;

            Box1.AssignLength(2.0);
            Box1.AssignWidth(4.0);
            Box1.AssignHeight(6.0);

            Box2.AssignLength(1.0);
            Box2.AssignWidth(3.0);
            Box2.AssignHeight(5.0);

            volumetric = Box1.Volumetric();
            Console.WriteLine("The volumetric of box1 is {0}", volumetric);

            volumetric = Box2.Volumetric();
            Console.WriteLine("The volumetric of box2 is {0}", volumetric);

            Box3 = Box1 + Box2;
            volumetric = Box3.Volumetric();
            Console.WriteLine("The volumetric of box3 is {0}", volumetric);

        }
    }
}