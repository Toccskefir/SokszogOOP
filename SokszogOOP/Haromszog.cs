using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private double b;
        private double c;

        public Haromszog(double a, double c, double b) : base(a)
        {
            this.b = b;
            this.c = c;
            if (!IsEditable())
            {
                throw new ArgumentException("A háromszög nem szerkeszthető!");
            }
        }

        public Haromszog() : base(RandomLength())
        {
            do
            {
                this.b = RandomLength();
                this.c = RandomLength();
                base.A = RandomLength();
            } while (!this.IsEditable());
        }

        public override double A
        { 
            set
            {
                base.A = value;
                if (!IsEditable())
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
                }
            }
        }
        public double B
        {
            get => b;
            set
            {
                b = value;
                if(!IsEditable())
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
                }
            }
        }
        public double C
        {
            get => c;
            set
            {
                c = value;
                if (!IsEditable())
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető!", nameof(value));
                }
            }
        }

        private bool IsEditable()
        {
            return this.A + this.b > this.c
                && this.A + this.c > this.b
                && this.c + this.b > this.A;
        }

        

        public override double GetPerimeter()
        {
            return this.A + this.b + this.c;
        }

        public override double GetArea()
        {
            double s = (this.A + this.b + this.c) / 2;
            return Math.Sqrt(s * (s - this.A) * (s - this.b) * (s - this.c));
        }

        public override string ToString()
        {
            return $"A oldal: {this.A} - B oldal: {this.b} - C oldal: {this.c} - {base.ToString()}";
        }
    }
}