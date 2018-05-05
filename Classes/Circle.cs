using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask.Classes
{
    public class Circle: Figure
    {
        protected double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set 
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Error: Radius cannot be less than zero");
                    }
                    else
                    {
                        radius = value;
                    }
                }
                catch (ArgumentException exception)
                { 
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public Circle(string countourColor, string fillCollor, double widht,double RADIUS)
            :base(countourColor,fillCollor,widht)
        {
            this.Radius = RADIUS;
        }
        public override double Area()
        {
            return PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * PI * radius;
        }
        public override double Volume()
        {
            return 0;
        }
        public override void Show()
        {
            Console.WriteLine("Circle:");
            base.Show();
            Console.WriteLine($"radius = {Radius}");
        }
    }
}
