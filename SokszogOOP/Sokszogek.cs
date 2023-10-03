using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Sokszogek
    {
        private List<Sokszog> list;
        private static Random rnd = new Random();

        public Sokszogek()
        {
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Teglalap(rnd.Next(5, 15), rnd.Next(5, 15)));
                list.Add(new Haromszog());
                list.Add(new Paralelogramma());
            }
            
        }
    }
}
