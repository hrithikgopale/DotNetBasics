// See https://aka.ms/new-console-template for more information
using System;

class MyMain
{
    static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,6,7,8,9,10};
        Console.WriteLine("By using for loop");
        for (int i = 0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+",");
        }

        Console.WriteLine("\n By using for each loop");

        foreach(int x in arr)
        {
            Console.Write(x+" ");   
        }
        Console.WriteLine("\nDisplay all odd numbers");
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2!=0)
            {
                Console.Write(arr[i]+" ");
            }
        }
      //  Console.WriteLine("\n");
        // 2d element
        int[] oned = new int[5];
        Console.WriteLine("\nEnter Element:");
        for (int i = 0;i<oned.Length;i++)
        {
            
            oned[i]=int.Parse(Console.ReadLine());

        }
        int j;
        Console.Write("Elements are: ");
        for (j = 0; j < oned.Length; j++)
        {
            Console.Write(+oned[j]+" ");
        }

        Console.Write("\nSorting in Descending order: ");
        int temp;
        for(int i = 0; i < oned.Length; i++)
        {
            for(j=i+1; j<oned.Length;j++)
            {
                if (oned[i] > oned[j])
                {
                    temp = oned[i];
                    oned[i] = oned[j];
                    oned[j] = temp;
                }
                
               
            }
        }
        for(int i = 0; i < oned.Length; i++)
        {
            Console.Write(oned[i]+" ");
        }

        int[,] td= new int[3,3];
        int a, b;
        Console.WriteLine("\nEnter elements");
        for (a = 0; a <3; a++)
        {
            for(b=0;b<3;b++)
            {
                td[a,b]=int.Parse(Console.ReadLine());
               // Console.WriteLine(td[a,b])
            }
            Console.WriteLine();
        }
        //present 2d elements
        Console.WriteLine("\nElements are: ");
        for(a=0;a<3; a++)
        {
            for(b=0;b<3;b++)
            {
                Console.Write(td[a,b]+" ");
            }
            Console.WriteLine();
        }

    }
}
