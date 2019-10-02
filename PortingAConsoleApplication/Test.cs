using System;

// Mike Prelesnik
// Porting a Java Assignment to C#
// Assignment 2

namespace PortingAConsoleApplication
{
    class Test
    {
        static void Main(string[] args)
        {
            LinkedIntList linkedList = new LinkedIntList();

            //test with an empty list
            Console.WriteLine(linkedList.toString());

            //fill the list with some values
            for (int i = 1; i < 5; i++)
            {
                linkedList.add(i);
            }

            //test with a populated list
            Console.WriteLine(linkedList.toString());

            //test the contains method
            //in the list - should return true
            Console.WriteLine("Is 2 in the list? " + linkedList.contains(2));
            //not in the list - should return false
            Console.WriteLine("Is 50 in the list? " + linkedList.contains(50));
        }
    }
}
