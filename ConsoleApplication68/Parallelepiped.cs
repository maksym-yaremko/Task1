using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Parallelepiped:Rectangle
    {
        public double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("height can not be <=0");
                }
                else
                {
                    height = value;
                }
            }
        }
        public Parallelepiped(string countourColor, string fillCollor, double widht, double side_A, double side_B, double HEIHGT) 
            : base(countourColor, fillCollor, widht,side_A,side_B)
        {
            this.Height = HEIHGT;
        }
        public override double Area()
        {
            return 2*(Side_A*Side_B+Side_A*Height+Side_B*Height);
        }
        public override double Volume()
        {
            return Side_A* Side_B* Height;
        }
        public override void Show()
        {
            Console.WriteLine("Parallelepiped:");
            base.Show();
            Console.WriteLine("HEIHGT = "+ Height);
        }
    }
}
