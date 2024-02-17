//using System;
//using System.Text;

//namespace BasicConsole;



//// Driver Class 
//class Geeks
//{




//// Main Method 
//public static void Main(String[] args)

//{
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
//    int[] favNums = new int[3];
//    favNums[0] = 23;
//    String[] customers = { "Bob", "Sally", "Sue" };
//    var employees = new[] { "Mike", "Paul", "Rick" };
//    object[] randomeArray = { "Paul", 45, 1.234 };
//    Console.WriteLine("randomArray 0:{0}", randomeArray[0].GetType());
//    Console.WriteLine("randomArray");




//    Console.WriteLine("-------------------");

//    String[,] custNames = new string[2, 2] { { "Bob", "Kensmith" }, { "Sally", "Smith" } };
//    Console.WriteLine("MD Value: {0}", custNames.GetValue(1, 0));

//    for(int j =0; j<custNames.GetLength(0); j++)

//    {
//        for (int k = 0; k < custNames.GetLength(0); k++) {
//            Console.WriteLine("{0} ", custNames[j, k]);
//        }
//        Console.WriteLine();

//    }

//}


//}

//using System;
//namespace ValueTypeTest
//{

//    class GeeksforGeeks
//    {

//        // Main function 
//        static void Main()
//        {

//            // declaring character 
//            char a = 'G';

//            // Integer data type is generally 
//            // used for numeric values 
//            int i = 89;

//            short s = 56;

//            // this will give error as number 
//            // is larger than short range 
//            // short s1 = 87878787878; 

//            // long uses Integer values which  
//            // may signed or unsigned 
//            long l = 4564;

//            // UInt data type is generally 
//            // used for unsigned integer values 
//            uint ui = 95;

//            ushort us = 76;
//            // this will give error as number is 
//            // larger than short range 

//            // ulong data type is generally 
//            // used for unsigned integer values 
//            ulong ul = 3624573;

//            // by default fraction value 
//            // is double in C# 
//            double d = 8.358674532;

//            // for float use 'f' as suffix 
//            float f = 3.7330645f;

//            // for float use 'm' as suffix 
//            decimal dec = 389.5m;

//            Console.WriteLine("char: " + a);
//            Console.WriteLine("integer: " + i);
//            Console.WriteLine("short: " + s);
//            Console.WriteLine("long: " + l);
//            Console.WriteLine("float: " + f);
//            Console.WriteLine("double: " + d);
//            Console.WriteLine("decimal: " + dec);
//            Console.WriteLine("Unsinged integer: " + ui);
//            Console.WriteLine("Unsinged short: " + us);
//            Console.WriteLine("Unsinged long: " + ul);
//        }
//    }
//}




// C# program to demonstrate  
// the Reference data types 
using System;
//namespace ValueTypeTest
//{

//    class GeeksforGeeks
//    {

//        // Main Function 
//        static void Main()
//        {

//            // declaring string 
//            string a = "Geeks";

//            //append in a 
//            a += "for";
//            a = a + "Geeks";
//            Console.WriteLine(a);

//            // declare object obj 
//            object obj;
//            obj = 20;
//            Console.WriteLine(obj);

//            // to show type of object 
//            // using GetType() 
//            Console.WriteLine(obj.GetType());
//        }
//    }
//}






// Main function
//using System;
//class Geeks
//{

//    // Main Method 
//    public static void Main(String[] args)
//    {

//        // Value will be taken from user  
//        // input and assigned to variable 
//        // num
//        Console.WriteLine("Please enter your number");
//        int num = Convert.ToInt32(Console.ReadLine());

//        // printing the result 
//        Console.WriteLine("Value of num is " + num);

//    }
//}

//using System;
//namespace Assignment
//{

//    class GFG
//    {

//        // Main Function
//        static void Main(string[] args)
//        {

//            // initialize variable x
//            // using Simple Assignment 
//            // Operator "="
//            int x = 15;

//            // it means x = x + 10
//            x += 10;
//            Console.WriteLine("Add Assignment Operator: " + x);

//            // initialize variable x again
//            x = 20;

//            // it means x = x - 5
//            x -= 5;
//            Console.WriteLine("Subtract Assignment Operator: " + x);

//            // initialize variable x again
//            x = 15;

//            // it means x = x * 5
//            x *= 5;
//            Console.WriteLine("Multiply Assignment Operator: " + x);

//            // initialize variable x again
//            x = 25;

//            // it means x = x / 5
//            x /= 5;
//            Console.WriteLine("Division Assignment Operator: " + x);

//            // initialize variable x again
//            x = 25;

//            // it means x = x % 5
//            x %= 5;
//            Console.WriteLine("Modulo Assignment Operator: " + x);

//            // initialize variable x again
//            x = 8;

//            // it means x = x << 2
//            x <<= 2;
//            Console.WriteLine("Left Shift Assignment Operator: " + x);

//            // initialize variable x again
//            x = 8;

//            // it means x = x >> 2
//            x >>= 2;
//            Console.WriteLine("Right Shift Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x &= 4;
//            Console.WriteLine("Bitwise AND Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x ^= 4;
//            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x |= 4;
//            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);

//        }
//    }
//}

//using System;

//public class Student
//{

//    // Declare name field  
//    private string name = "GeeksforGeeks";

//    // Declare name property  
//    public string Name
//    {

//        // get is contextual keyword 
//        get
//        {
//            return name;
//        }

//        // set is a contextual 
//        // keyword 
//        set
//        {
//            name = value;
//        }
//    }
//}

//class TestStudent
//{

//    // Main Method  
//    public static void Main(string[] args)
//    {
//        Student s = new Student();

//        // calls set accessor of the property Name,  
//        // and pass "GFG" as value of the  
//        // standard field 'value'.  
//        s.Name = "GFG";

//        // displays GFG, Calls the get accessor  
//        // of the property Name.  
//        Console.WriteLine("Name: " + s.Name);

//        // using get and set as identifier 
//        int get = 50;
//        int set = 70;

//        Console.WriteLine("Value of get is: {0}", get);
//        Console.WriteLine("Value of set is: {0}", set);
//    }
//}



using System;

// Class Declaration
public class Dog
{

    // Instance Variables
    String name;
    String breed;
    int age;
    String color;

    // Constructor Declaration of Class
    public Dog(String name, String breed,
                  int age, String color)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
        this.color = color;
    }

    // Property 1
    public String GetName()
    {
        return name;
    }

    // Property 2
    public String GetBreed()
    {
        return breed;
    }

    // Property 3
    public int GetAge()
    {
        return age;
    }

    // Property 4
    public String GetColor()
    {
        return color;
    }

    // Method 1
    public String ToString()
    {
        return ("Hi my name is " + this.GetName()
                + ".\nMy breed, age and color are " + this.GetBreed()
                + ", " + this.GetAge() + ", " + this.GetColor());
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating object
        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
        Console.WriteLine(tuffy.ToString());
    }
}