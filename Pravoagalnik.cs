using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura2
{
   public class Pravoagalnik:Figura
    {
        public Pravoagalnik(int a, int b):base(a,b)
        {

        }
        public override double Area()
        {
            return a * b;
        }
        public override double Perimetar()
        {
            return 2 * a + 2 * b;
        }
    }
}
