using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura2
{
    public abstract class Figura
    {
        protected int a;
        protected int b;
        public Figura(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public abstract double Area();
        public abstract double Perimetar();
    }
}
