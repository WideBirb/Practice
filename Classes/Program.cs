using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {

        enum CarColor : byte
        {
            Orange = 0,
            Red = 1,
            Green = 2,
            Blue = 3,
        }

        static void PaintCar(CarColor car)
        { 
            
        }

        public static void Swap(ref int num3, ref int num4)
        {
			CarColor car = CarColor.Orange;
			PaintCar(car);
			int age = 0;
			bool isGay = age < 10 ? true : false;
		}
        static void Main(string[] args)
        {
			Rectangle rect;
			rect.length = 200;
			rect.width = 50;
			Console.WriteLine("Area of rect1: {0}",
				rect.Area());

			Rectangle rect2 = new Rectangle(100, 40);
			rect2 = rect;
			rect.length = 33;
			Console.WriteLine("Rect2.length: {0}", 
				rect2.length);

			Animal fox = new Animal()
			{
				name = "Red",
				sound = "rawr"
			};

			Console.WriteLine("# of Animals {0}", 
				Animal.GetNumAnimals());

			Console.WriteLine("Area of Rectangle: {0}", 
				ShapeMath.GetArea("Rectangle", 5, 6));
        }

		struct Rectangle
		{
			public double length;
			public double width;
			public Rectangle(double l = 1, double w = 1)
			{
				length = l;
				width = w;
			}

			public double Area()
			{
				return length * width;
			}
		}
	}
}
