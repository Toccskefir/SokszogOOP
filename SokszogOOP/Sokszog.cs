using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal abstract class Sokszog
    {
        private double a;

        public Sokszog(double a)
        {
            this.a = a;
        }

        public virtual double A { get => a; set => a = value; }

        public abstract double GetPerimeter();        //absztrakt metódus

        public abstract double GetArea();       //absztrakt metódus

        public override string ToString()
        {
            return $"Kerület: {this.GetPerimeter()} - Terület: {this.GetArea()}";
        }
    }
}