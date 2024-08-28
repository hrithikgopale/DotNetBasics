using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringproblems
{
     class Basic
    {
        public string Test1(string s) 
        {
            if (s.Length<2) {
                Console.WriteLine(s);
            }
            else
            {
                //repeted substrngtring
                string st = s.Substring(0, 2);
                return s.Substring(0, 2) + st + st + st;
            }
            return s;
        }
    }
}
