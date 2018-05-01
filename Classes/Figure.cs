using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask.Classes
{
    public abstract class Figure
    {
        protected static double PI = 3.1415;
        protected double widhts;
        public string CountourColour { get; set; }
        public double Widhts
        {
            get
            {
                return widhts;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("weidths can not be <= 0");
                    widhts = 0;
                }
                else
                {
                    widhts = value;
                }
            }
        }
        public string FillCollor { get; set; }
        protected Figure(string countourColor,string fillCollor,double widht)
        {
            this.CountourColour = countourColor;
            this.FillCollor = fillCollor;
            this.Widhts = widht;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();
        public virtual void Show()
        {
            Console.WriteLine("countourColor = "+ CountourColour);
            Console.WriteLine("fillCollor = "+ FillCollor);
            Console.WriteLine("widht = "+ Widhts);
        }
    }
}
