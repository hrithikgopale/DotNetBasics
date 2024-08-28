using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    delegate int Calci(int a, int b);
    class CalciTest
    {
      public static int add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public static int sub(int a, int b)
        {
            int c= a - b;
            return c;
        }
       public static int mul(int a, int b)
        {
            int c= a * b;
            return c;
        }
    }
}
