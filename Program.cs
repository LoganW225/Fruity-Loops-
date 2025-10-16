using System;
using System.Collections.Generic;

namespace fruit_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make a list of fruits
            List<string> FruitLoops = new  List<string> { "Apple", "Banana", "Cherry", "Mango", "Grape" };
          

             Console.WriteLine("Initial fruits:");
            // show each fruit (simple loop)
            foreach (string f in FruitLoops)
            {
                Console.WriteLine("- " + f);
            }
             Console.WriteLine();

            // add 2 fruits
            FruitLoops.Add("Pineapple");
            FruitLoops.Add("orange"); 
            Console. WriteLine("After adding 2 (used Add):");
            for (int i = 0; i < FruitLoops.Count; i++)
            {
                 Console.WriteLine(i + ": " + FruitLoops[i]);
            }
            Console. WriteLine();

            // remove 1 fruit by index 3rd item
            FruitLoops.RemoveAt(2); // removes "Cherry" becuase index starts at 0
             Console.WriteLine("After RemoveAt(2):");
            for (int i = 0; i < FruitLoops.Count; i++)
            {
                Console.WriteLine(i + ": " + FruitLoops[i]);
            }
            Console.WriteLine();

             // check if Banana is there
             bool hasBanana = FruitLoops.Contains("Banana"); 
             Console.WriteLine("Contains(\"Banana\") = " + hasBanana);

            // get index of Mango
            int mintMango = FruitLoops.IndexOf("Mango"); // -1 if not found
            Console.WriteLine("IndexOf(\"Mango\") = " + mintMango);

            // how many items right now
            int total = FruitLoops.Count; // just the size
            Console.WriteLine("Count = " + total);
            Console.WriteLine();

              // sort a-z which changes the list
              FruitLoops.Sort();
              Console.WriteLine("After Sort():");
              for (int i = 0; i < FruitLoops.Count; i++)
            {
                Console.WriteLine(i + ": " + FruitLoops[i]);
            }
             Console.WriteLine();

            // reverse
             FruitLoops.Reverse();
             Console.WriteLine("After Reverse():");
              for (int i = 0; i < FruitLoops.Count; i++)
            {
                Console.WriteLine(i + ": " + FruitLoops[i]);
            }

           
        }
    }
}