using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList() { "Boat", "House", "Cat", "River", "Cupboard" };

            Console.WriteLine("Plural Of All Words: \n");
            foreach (string arr in array)
            {
                Console.WriteLine(arr + "s");
            }
            //Replacing 2nd word With synonym
            string s = (string)array[1];
            Console.WriteLine("\nSynonym of :  " + s );
            if (s == "Boat")
            {
                array[1] = "\nVessel";
                Console.WriteLine(array[1]);
            }
            else if (s == "House")
            {
                array[1] = "Home";
                Console.WriteLine(array[1]);
            }
            else if (s == "\nCat")
            {
                array[1] = "\nKitten";
                Console.WriteLine(array[1]);
            }
            else if (s == "River")
            {
                array[1] = "\nStream";
                Console.WriteLine(array[1]);
            }
            else
            {
                array[1] = "\nWardrobe";
                Console.WriteLine(array[1]);
            }
            array.Add("Teacher");
            Console.WriteLine("\nNo of Words:" + array.Count);
            Console.WriteLine("\nWords Of length 7 is :");
            for (int i = 0; i < array.Count; i++)
            {
                string w = (string)array[i];
                if (w.Length == 7)
                {
                    Console.WriteLine(array[i]);
                }
           }
            Console.WriteLine("\nWord at 3rd position:"+array[2]);
            Console.WriteLine("\nAfter Sorting : \n");
            array.Sort();
            foreach(string S in array)
            {
                Console.WriteLine(S);
            }
            Console.WriteLine("\nReverse Of array : \n");
            array.Reverse();
            foreach (string S in array)
            {
                Console.WriteLine(S);
            }
        }

    }
}
    
