using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Paralelogramma : Teglalap
    {
        private double alfa;
        private static Random rnd = new Random();

        public Paralelogramma(double a, double b, double alfa) : base(a, b)
        {
            this.alfa = alfa;
        }

        public Paralelogramma() : base(rnd.Next(5,20), rnd.Next(5, 20))
        {
            this.alfa = rnd.Next(1, 180);
        }

        public double Alfa { get => alfa; set => alfa = value; }

        public override double GetArea()
        {
            double radian = this.alfa / 180;
            return this.A * this.B * Math.Sin(radian);
        }

        public override string ToString()
        {
            return $"Bezárt szög: {this.alfa} fok - {base.ToString()}";
        }
    }
}
