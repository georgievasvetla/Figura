using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura2
{
   public class Triagalnik:Figura

    {
        private int c;
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public Triagalnik(int a, int b,int c) : base(a, b)
        {
            this.c = c;
        }
        public override double Area()
        {
            return (a * b) / 2;
        }
        public override double Perimetar()
        {
            return a + b + c;
        }

    }
}
