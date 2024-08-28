using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramPractices
{
     class Practice1
    {
        public void createHarmonicMean(int n)
        {
            double sum = 0.0;
            int i;
            for(i =1;i<=n;i++)
            {
                if (i == 1)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("+1/" + i);
                }
                sum += 1 /(double) i;
            }
            Console.WriteLine($"\nSum of Series upto {n} terms:{sum}");
        }
        public void OddEvenPattern(int n)
        {
            int start = 1;
            for(int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    start = 1;
                   // Console.WriteLine(start);
                    //   Console.Write("0");
                }
                else
                    start = 0;

                for(int j = 1;j <= i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
        }
    }
}
