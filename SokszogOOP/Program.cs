using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Haromszog haromszog1 = new Haromszog();
            Haromszog haromszog2 = new Haromszog(3, 4, 5);
            Teglalap teglalap1 = new Teglalap(3, 5);
            Teglalap teglalap2 = new Teglalap(4, 2);
            Paralelogramma paralelogramma1 = new Paralelogramma();
            Paralelogramma paralelogramma2 = new Paralelogramma(10, 15, 60);
            Sokszogek sokszoglist = new Sokszogek();

            Console.WriteLine(haromszog1);
            Console.WriteLine(haromszog2);
            Console.WriteLine(teglalap1);
            Console.WriteLine(teglalap2);
            Console.WriteLine(paralelogramma1);
            Console.WriteLine(paralelogramma2);
            Console.WriteLine(sokszoglist);
            Console.Write("A sokszögek összkerülete: ");
            Console.WriteLine(sokszoglist.SumPerimeter());
            Console.Write("A sokszögek összterülete: ");
            Console.WriteLine(sokszoglist.SumArea());
            Console.Write("Legnagyobb területtel rendelkező sokszög sorszáma: ");
            Console.WriteLine(sokszoglist.MaxArea());

            try
            {
                haromszog2.C = 20;
                Console.WriteLine(haromszog2.A);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                paralelogramma1.Alfa = 180;
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            Console.ReadKey();
        }
    }
}