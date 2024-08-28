// See https://aka.ms/new-console-template for more information

class MyMain
{
    static int computeSum(int a,int b)
    {

        int result;
        if (a == b)
        {
             result = 3 * (a + b);
        }
        else
        {
             result = a + b;
        }
        return result;
    }
    static int absoluteDifference(int x,int y)
    {
        y = 51;
        return x > y ? (x - y) * 3 : x - y;
    }
    static void add(int a,int b)
    {
        int c = a + b;
        Console.WriteLine($"The sum is {c}");
    }
    static void sub(int a, int b)
    {
        int c = a - b;
        Console.WriteLine($"The substract is {c}");
    }
    static void mul(int a, int b)
    {
        int c = a * b;
        Console.WriteLine($"The multiplication  of {a} and {b} is {c}");
    }
    static void div(int a, int b)
    {
        int c = a / b;
        Console.WriteLine($"The division is {c}");
    }
    static void checkAge(int a)
    {
        int age;
        Console.WriteLine("Enter age");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You look like {0}", age);
    }
    static void swap(int a, int b)
    {
       int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After Swapping");
        Console.WriteLine(a + " " + b);
    }
    static void Main(string[] args)
    {
        /*
         *  int temp, a, b;
        Console.WriteLine("Enter first number: ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        b =int.Parse(Console.ReadLine());
        add(a,b);
        sub(a, b);
        mul(a, b);
        div(a, b);
        swap(a, b);
        checkAge(a);
         */
        int x = 51;
        int y;
        int r = absoluteDifference(x, y);

        int[,] arr = { {1,2}, {3,2 }, {2,2 } };
        int i,num1,num2;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            num1 = arr[i, 0];
            num2= arr[i, 1];
            int result=computeSum(num1,num2);
            Console.WriteLine(result);

        }
    }
}