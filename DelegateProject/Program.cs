// See https://aka.ms/new-console-template for more information
using DelegateProject;
using System;
class MyMain
{
    static void Main(string[] args)
    {
        /*
         *   Calci c1 = new Calci(CalciTest.add);
        Console.WriteLine($"The Addition is{c1(9, 2)}");

        Calci c2=new Calci(CalciTest.sub);
        Console.WriteLine($"The substraction is {c2(9,5)}");

        Calci c3=new Calci(CalciTest.mul);
        Console.WriteLine($"The multiplication is {c3(3, 4)}");
         */


        CalciTest2 ob =new CalciTest2();
        Calci2 c1 = new Calci2(ob.add);
        c1(4, 2);
        Console.WriteLine($"The Addition is {c1(4, 2)}");

        Calci2 c2 = new Calci2(ob.sub);
        Console.WriteLine($"The substraction is{c2(10,3)} ");

        
        
    }
}