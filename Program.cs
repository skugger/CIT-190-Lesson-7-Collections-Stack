using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_Stack
{
    class Program
    {
        public static void Main()
        {

            Stack <string> bookTitles = new Stack <string>();

            bookTitles.Push("The Positronic Man");
            bookTitles.Push("The Caves of Steel");
            bookTitles.Push("The Naked Sun");
            bookTitles.Push("The Robots of Dawn");
            bookTitles.Push("Pebble in the Sky");

            foreach (var b in bookTitles)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();
            Console.WriteLine("These are " + bookTitles.Count + " books by Isaac Asimov.");

            Console.WriteLine();
            Console.WriteLine("Is one of them named 'Pebble in the Sky'? " + bookTitles.Contains("Pebble in the Sky") + "!");
            Console.WriteLine();

            Console.WriteLine("Here's what happens when you remove the top item...");
            bookTitles.Pop();
            Console.WriteLine("now there's " + bookTitles.Count + " left:");
            Console.WriteLine();

            foreach (var b in bookTitles)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();


        }
    }
}
