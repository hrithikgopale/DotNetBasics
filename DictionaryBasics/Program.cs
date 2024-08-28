
using DictionaryBasics;

class Program
{
    static void Main(string[] args)
    {

        Calci c=new Calci();
        Console.WriteLine(c.mul(7, 4));
        Console.WriteLine(c.sub(4, 3));
        

        /*
         *    Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(101, "Hrithik");
        dict.Add(102, "Adesh");
        dict.Add(103, "Rohit");
        dict.Add(104, "Raj");
        // Console.WriteLine(dict.Values);
        foreach (var item in dict.Values)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nKeys are");
        foreach (var item in dict.Keys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("key value pair is");

        foreach (KeyValuePair<int, string> kv in dict)
        {

            Console.WriteLine(kv.Key + " " + kv.Value);
        }
         *   
         */





    }
}