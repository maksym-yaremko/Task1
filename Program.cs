using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceTask.Classes;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder newCircle;
            while (true)
            {
                double width = double.Parse(Console.ReadLine().ToString());
                double radius = double.Parse(Console.ReadLine().ToString());
                double height = double.Parse(Console.ReadLine().ToString());
                newCircle = new Cylinder("1", "1", width, radius,height);
                newCircle.Show();
                Console.WriteLine(newCircle.Volume());
                Console.WriteLine(newCircle.Area());
            }
        }
    }
}
