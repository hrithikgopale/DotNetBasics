using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    delegate int Calci2(int a, int b);
     class CalciTest2
    {
        public int add(int a, int b)
        {
            int c;
            c = a + b; return c;
        }
        public int sub(int a, int b)
        {
            int c = a - b; return c;
        }
        public int mod(int a, int b)
        {
            int c = a % b; return c;
        }
    }
}
