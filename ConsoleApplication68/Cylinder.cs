﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Cylinder:Circle
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
        public Cylinder(string countourColor, string fillCollor, double widht, double RADIUS,double HEIHGT) 
            : base(countourColor, fillCollor, widht, RADIUS)
        {
            this.Height = HEIHGT;
        }
        public override double Area()
        {
            return 2 * PI * Radius * (Radius + Height);
        }
        public override double Volume()
        {
            return PI * Math.Pow(Radius, 2) * Height;
        }
        public override void Show()
        {
            Console.WriteLine("Cylinder:");
            base.Show();
            Console.WriteLine("HEIHGT = "+Height);
        }
    }
}
