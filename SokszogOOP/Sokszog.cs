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
        private static Random rnd = new Random();

        public Sokszog(double a)
        {
            this.a = a;
        }

        public virtual double A { get => a; set => a = value; }

        public abstract double GetPerimeter();        //absztrakt metódus

        public abstract double GetArea();       //absztrakt metódus

        protected static int RandomLength()
        {
            return rnd.Next(5, 15);
        }

        protected static int RandomAngle()
        {
            return rnd.Next(1,180);
        }

        public override string ToString()
        {
            return $"Kerület: {this.GetPerimeter()} - Terület: {this.GetArea()}";
        }
    }
}