using System;
using System.Text;

namespace BasicConsole;



// Driver Class 
class Geeks
{




    // Main Method 
    public static void Main(String[] args)

    {
        //Strings

        //string RandString = "This is a string";
        //Console.WriteLine("String length: {0}", RandString.Length);
        //Console.WriteLine("String Contains is: {0}", RandString.Contains("is"));
        //Console.WriteLine("String Index is: {0}", RandString.IndexOf("is"));
        //Console.WriteLine("String Remove is: {0}", RandString.Remove(10,6));
        //Console.WriteLine("String Length is: {0}", RandString.Length);
        //Console.WriteLine("String Insert is: {0}", RandString.Insert(10,"short"));
        //Console.WriteLine("Replace String: {0}", RandString.Replace("string", "sentence"));
        //Console.WriteLine("Compare A to B: {0}", RandString.Length);
        //Console.WriteLine("Compare A to B: {0}", String.Compare("A","B",StringComparison.OrdinalIgnoreCase));
        //Console.WriteLine("------------------------");
        //Console.WriteLine("A=a:{0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
        //Console.WriteLine("Pad Left:{0}", RandString.PadLeft(20, '.'));

        //Console.WriteLine("Pad Right:{0}", RandString.PadRight(20, '.'));
        //Console.WriteLine("Trim: {0}", RandString.Trim());

        //Console.WriteLine("Uppercase: {0}", RandString.ToUpper());

        //Console.WriteLine("LowerCase: {0}", RandString.ToLower());
        //string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating","field");
        //Console.Write(newString + "\n");

        //Console.WriteLine(@"Exactly what I typed\n");

        //ARRAYS
        int[] favNums = new int[3];
        favNums[0] = 23;
        String[] customers = { "Bob", "Sally", "Sue" };
        var employees = new[] { "Mike", "Paul", "Rick" };
        object[] randomeArray = { "Paul", 45, 1.234 };
        Console.WriteLine("randomArray 0:{0}", randomeArray[0].GetType());
        Console.WriteLine("randomArray");




        Console.WriteLine("-------------------");

        String[,] custNames = new string[2, 2] { { "Bob", "Kensmith" }, { "Sally", "Smith" } };
        Console.WriteLine("MD Value: {0}", custNames.GetValue(1, 0));

        for(int j =0; j<custNames.GetLength(0); j++)

        {
            for (int k = 0; k < custNames.GetLength(0); k++) {
                Console.WriteLine("{0} ", custNames[j, k]);
            }
            Console.WriteLine();

        }

    }


}