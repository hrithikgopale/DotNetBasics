using stringproblems;
using System;
class Program
{
    static string CreateFourCopies(string str)
    {
        if (str.Length < 2)
        {
            return str;
        }
        else
        {
            string front = str.Substring(0, 2);
            return front + front + front + front;
        }
    }
    public string convertUpperString(string str)
    {
        if (str.Length < 3)
        {
            return str;
        }else
        {
            int firstindex = str.Length - 3;
            string f = str.Substring(0, firstindex);
            string s= str.Substring(firstindex).ToUpper();
            return f+s;
        }
        
    }
    public bool commonDigit(int x,int y)
    {
        return Math.Abs(x % 10) == Math.Abs(y % 10);
    }
    public bool checkstring(string s)
    {
        int count = 0;
        //check string is present or not
        foreach(char c in s)
        if (c=='z' || c=='Z')
        {
                count++;
        }
        //if found return true
        return count >= 2 || count <= 4;
    }
    static string frontAndBackString(string str)
    {
        char lastchar=str[str.Length-1];
        return lastchar + str + lastchar;
    }
    static void Main(string[] a)
    {
        Program p=new Program();
       Console.WriteLine( p.checkstring("friZz"));
        Console.WriteLine(p.convertUpperString("program"));
        Console.WriteLine(p.convertUpperString("cpp"));
        int x = 254, y = 512;
        Console.WriteLine(p.commonDigit(x, y));
        string s = "Hrithik Gopale";
        Console.WriteLine(test(s));
        Console.WriteLine("else");
        Console.WriteLine(s.Length);//14
        Console.WriteLine(s[4]);//h
        Console.WriteLine(s.IndexOf('i'));//2
        Console.WriteLine(s.IndexOf('s')); // if its not present return -1
        Console.WriteLine(s.IndexOf('k')); // 6
        Console.WriteLine(s.LastIndexOf("i"));//5
        Console.WriteLine(s.ToLower());    //hrithik gopale
        Console.WriteLine(s.ToUpper());// Hrithik Gopale
        Console.WriteLine(s.StartsWith("Hrithik"));// return true if present
        Console.WriteLine(s.EndsWith("Gopale"));// return true if present
        Console.WriteLine(s.Contains("Gopale"));
        Console.WriteLine(s.Equals("Hrithik Gopale"));//true
        Console.WriteLine(s.Equals("Hrithik gopale"));//false
        Console.WriteLine(s.Equals("Hrithik gopale"));//false
        Console.WriteLine(s.Equals("Hrithik gopale",StringComparison.OrdinalIgnoreCase));//true
        Console.WriteLine(s.Substring(0,5));//
        Console.WriteLine(s.Substring(0,s.Length-2));//rithik Gopale
        Console.WriteLine(s.Substring(1,s.Length-1));//
                                                     // Get a substring between two strings
       // Basic b=new Basic();
        //
       
        // Extract value of each attribute
        string author = "Name: Mahesh Chand, Book: C# Programming, Publisher: C# Corner, Year: 2020";
        string[] authorInfo = author.Split(", ");
        foreach (string info in authorInfo)
        {
            Console.WriteLine("   {0}", info.Substring(info.IndexOf(": ") + 1));
        }
        int firstStringPosition = author.IndexOf("Mahesh");
        int secondStringPosition = author.IndexOf("Chand");
        string stringBetweenTwoStrings = author.Substring(firstStringPosition,
            secondStringPosition - firstStringPosition + 7);
        Console.WriteLine(stringBetweenTwoStrings);

        string[] inputs = { "C Sharp", "JS", "a" };

        Console.WriteLine("Sample Input:");
        foreach (string input in inputs)
        {
            Console.WriteLine(input);
        }

        Console.WriteLine("\nExpected Output:");
        foreach (string input in inputs)
        {
            string result = CreateFourCopies(input);
            Console.WriteLine(result);
        }
        Console.WriteLine("\nExpected Output:");
        foreach (string input in inputs)
        {
            string result = frontAndBackString(input);
            Console.WriteLine(result);
        }
    }//main
    static string test(string s)
    {
        if(s.Length>2 && s.Substring(0,2).Equals("if"))
        {
            return s;
        }
        return "if " + s;
    }
    
}