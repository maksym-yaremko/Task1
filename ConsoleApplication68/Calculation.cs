using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Calculation
    {
        public double AreaCalulation(List<Figure> figure)
        {
            double AreaSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                AreaSum = AreaSum + figure[i].Area();
            }
            return AreaSum;
        }

        public double PerimetrCalculation(List<Figure> figure)
        {
            double PerimetrSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                PerimetrSum = PerimetrSum + figure[i].Perimetr();
            }
            return PerimetrSum;
        }

        public double VolumeCalculation(List<Figure> figure)
        {
            double VolumeSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                VolumeSum = VolumeSum + figure[i].Volume();
            }
            return VolumeSum;
        }

        public void ShowInfo(List<Figure> figure)
        {
            for (int i=0;i<figure.Count;i++)
            {
                figure[i].Show();
                Console.WriteLine();
            }
        }

        public void OutputCalculation()
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Circle("black", "white", 5.6, 10));
            figures.Add(new Rectangle("purple", "pink", 2.4, 3, 4));
            figures.Add(new Cylinder("blue", "yellow", 4.4, 5, 6));
            figures.Add(new Parallelepiped("grey", "green", 3.2, 2, 9, 13));

            Console.WriteLine("Figures and its characterictics in list: ");
            Console.WriteLine();
            ShowInfo(figures);
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Calculation:");
            Console.WriteLine("sum of areas = {0}",AreaCalulation(figures));
            Console.WriteLine("sum of perimetres = {0}", PerimetrCalculation(figures));
            Console.WriteLine("sum of volumes = {0}",VolumeCalculation(figures));
            
        }
    }
}
