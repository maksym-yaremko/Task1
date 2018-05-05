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
            Calculation calc = new Calculation();
            calc.OutputCalculation();
            Console.ReadKey();
        }
    }
}
