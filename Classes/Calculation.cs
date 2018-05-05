using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask.Classes
{
    class Calculation
    {
        public double AreaCalulation(List<Figure> figure)
        {
            double areaSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                areaSum = areaSum + figure[i].Area();
            }
            return areaSum;
        }

        public double PerimetrCalculation(List<Figure> figure)
        {
            double perimetrSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                perimetrSum = perimetrSum + figure[i].Perimeter();
            }
            return perimetrSum;
        }

        public double VolumeCalculation(List<Figure> figure)
        {
            double volumeSum = 0;
            for (int i = 0; i < figure.Count; i++)
            {
                volumeSum = volumeSum + figure[i].Volume();
            }
            return volumeSum;
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
            var figures = new List<Figure>();
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
