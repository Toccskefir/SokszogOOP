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

        public Paralelogramma(double a, double b, double alfa) : base(a, b)
        {
            if (alfa >= 180)
            {
                throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb", nameof(alfa));
            }
            this.alfa = alfa;
        }

        public Paralelogramma() : base(RandomLength(), RandomLength())
        {
            this.alfa = RandomAngle();
        }

        public double Alfa
        {
            get => alfa;
            set
            {
                if (value >= 180)
                {
                    throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb", nameof(value));
                }
                this.alfa = value;
            }
        }

        public override double GetArea()
        {
            double radian = this.alfa / 180 * Math.PI;
            return this.A * this.B * Math.Sin(radian);
        }

        public override string ToString()
        {
            return $"Bezárt szög: {this.alfa} fok - {base.ToString()}";
        }
    }
}
