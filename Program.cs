using System;
using System.Threading.Channels;

namespace Static_Keyword
{
    //static classes(methods, fields, properties, constructors), are class members 
    //that can be accessed without the need to create any objects

    class Myclass
    {
        //Non static classes members
        public string Message = "Hello World";
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //static class members
        public static string greetings = "Good Morning";
        public static int Age { get; set; }

        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "==========Non Static Class Members=========");
            //To access the non static members of MyClass
            //from another class
            //we need to instantiate an object as follows
            Console.WriteLine("\n");
            Myclass classA = new Myclass();
            Console.WriteLine(classA.Message);
            classA.Name = "Jamie";
            classA.DisplayName();

            Console.WriteLine("\n" + "==========Static Class Members=========");
            //To access the static members,
            //we do not need to create any object
            //we simply use the class name to access them
            Console.WriteLine("\n");
            Console.WriteLine(Myclass.greetings);
            Myclass.Age = 39;
            Myclass.DisplayAge();
        }
    } 
}
