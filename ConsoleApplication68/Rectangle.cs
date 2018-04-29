using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Rectangle : Figure
    {
        public double side_a, side_b;
        public double Side_A
        {
            get
            {
                return side_a;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("side_a can not be <=0");
                }
                else
                {
                    side_a = value;
                }
            }
        }
        public double Side_B
        {
            get
            {
                return side_b;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("side_b can not be <=0");
                }
                else
                {
                    side_b = value;
                }
            }
        }
        public Rectangle(string countourColor, string fillCollor, double widht,double side_A,double side_B)
            : base(countourColor, fillCollor, widht)
        {
            this.Side_A = side_A;
            this.Side_B = side_B;
        }
        public override double Area()
        {
            return side_a*side_b;
        }
        public override double Perimetr()
        {
            return 2*(Side_A+Side_B);
        }
        public override double Volume()
        {
            return 0;
        }
        public override void Show()
        {
            Console.WriteLine("Recatangle:");
            base.Show();
            Console.WriteLine("side_A = "+ Side_A);
            Console.WriteLine("side_B = "+ Side_B);
        }
    }
}
