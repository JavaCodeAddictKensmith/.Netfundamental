using System;
using System.Text;

namespace BasicConsole;



// Driver Class 
class Geeks
{


    // Main Method 
    public static void Main(String[] args)
    {

        // creating the instance of  
        // Class GFG as "index" 
        StringBuilder sb = new StringBuilder("jjejeeje", 1);
        bool boolFromstr = bool.Parse("true");
        int intFrpmStr = int.Parse("100");
        double doubleFromStr = double.Parse("1.234");
        string strVal = doubleFromStr.ToString();
        Console.WriteLine($"Data type:{ strVal.GetType()}");
        double dblNum = 12.345;
        Console.WriteLine($"Integer :{(int)dblNum}");

    }
}