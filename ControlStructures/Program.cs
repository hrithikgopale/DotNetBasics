using System;


     class Looping
    {
        static void Main(string[] args)
        {
        //display 1-10 numbers
        /*
         * for (i=2;i<=n;i=i+2)
        {

            Console.Write(i+" ");
           
           
        }
         * 
         */
        int i,sum=0,n,r;
        Console.WriteLine("Enter number");
         n = int.Parse(Console.ReadLine());
        // n = 123;
        /*while (n!=0)
         {
             r = n % 10;
             sum += r;
             n /= 10;
         }
         Console.Write($"sum of Digits are {sum}");
         * 
         */
        
        int choice;
        while (true)
        {
            Console.WriteLine("Enter Choice:\n1:Deposit\n2:Withdraw \n3:Transaction \n4:Exit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Deposit State");
            }
            if (choice == 2)
            {
                Console.WriteLine("Deposit state");
            }
            if (choice == 3)
            {
                Console.WriteLine("Transaction state");
            }
            if (choice == 4)
            {
                Console.WriteLine("Exit");
                break;
            }
        }
        Console.ReadKey();
        }
    }

