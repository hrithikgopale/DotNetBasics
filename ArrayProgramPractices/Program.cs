using ArrayProgramPractices;
using System;

class ArrayProgram
{
    
    static void Main(string[] args)
    {
        try
        {
            /*int[] arr = new int[10];
            int sum = 0;
            double avg = 0;
            Console.WriteLine("Enter Array Elements:");
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The first 10 natural numbers are:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                sum = sum + arr[i];
                
            }
            avg = sum / 10.0;
            Console.WriteLine($"\n The  first {10} natural sum are {sum}");
            Console.WriteLine($"\n The  Average are {avg}");
             * 
             */

            int i;
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
           Practice1 p = new Practice1();
            //  p.createHarmonicMean(n);
            p.OddEvenPattern(n);
            /*
             * int sum = 0;
            Console.Write("\nOdd Numbers are: ");
            for (i = 1; i <=n; i++)
            {
                int evennumbers = 2 * i ;
                Console.Write(evennumbers + " ");
                sum += evennumbers;
            }
           Console.WriteLine($"\nThe Sum of odd Natural Number upto {n} terms: {sum}");
              */

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

       
    }
}
