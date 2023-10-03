using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Sokszogek
    {
        private List<Sokszog> list = new List<Sokszog>();
        private static Random rnd = new Random();

        public Sokszogek()
        {
            for (int i = 0; i < 10; i++)
            {
                int sokszog = rnd.Next(3);
                switch (sokszog)
                {
                    case 0:
                        this.list.Add(new Teglalap(rnd.Next(5, 15), rnd.Next(5, 15)));
                        break;
                    case 1:
                        this.list.Add(new Haromszog());
                        break;
                    case 2:
                        this.list.Add(new Paralelogramma());
                        break;
                    default:
                        break;
                }
            }
        }

        public double SumPerimeter()
        {
            double sum = 0;
            foreach (Sokszog item in list)
            {
                sum += item.GetPerimeter();
            }
            return sum;
        }

        public double SumArea()
        {
            double sum = 0;
            foreach (Sokszog item in list)
            {
                sum += item.GetArea();
            }
            return sum;
        }

        public int MaxArea()
        {
            int maxIndex = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].GetArea() > list[maxIndex].GetArea())
                {
                    maxIndex = i;
                }
            }
            return maxIndex + 1;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("Sokszögek:");
            foreach (Sokszog item in list)
            {
                sb.AppendLine();
                sb.AppendLine($" {item}");
            }
            return sb.ToString();
        }
    }
}
