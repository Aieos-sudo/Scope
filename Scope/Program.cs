using System;

namespace Scope
{
    internal class Program
    {
        /////////////////////////////////////////////////////////
        //Case:
        //thisisanexample
        //Camel Case
        string thisIsAnExample;
        //Snake Case
        string this_is_an_example;
        //Kabob Case
        //string this-is-an-example;

        /////////////////////////////////////////////////////////
        
        public static int i;
        public string test = "test";
        
        public static void Main(string[] args)
        {
            int k = 0;
            string temp = "temp";
            Console.WriteLine("In program" + i);
            i = 3;
            TestMethod();
            class2 class2 = new class2();
            class2.TestClass2();
        }

        public static void TestMethod()
        {
            int count = 4;
            Console.WriteLine("count in testMethod: " + count);
            Console.WriteLine("In program" + i);
        }
    }

    public class class2
    {
        public int i;


        public class2()
        {
            i = 6;
        }


        public void TestClass2()
        {
            Console.WriteLine("testing class 2");
            Console.WriteLine("i in testClass2 "+ i);
        }
    }
}
