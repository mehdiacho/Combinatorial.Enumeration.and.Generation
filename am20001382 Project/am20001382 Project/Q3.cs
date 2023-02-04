using System;
using System.Linq;
using System.Collections.Generic;
namespace am20001382_Project
{
    internal partial class Program
    {
        public static void Q3()
        {
            List<string> box = new List<string>(); //temporarily hold all forms of a structure
            string structure, a, b, c, cform;// = structs;
            Console.WriteLine("Enter structure");
            structure = Console.ReadLine();
            c = structure;
            int n = c.Length; //length of the structure
            for (int i = 0; i < n; i++) //create all forms of the current structure and stores in the "box" list
            {
                a = Convert.ToString(c.Last());
                b = c.Remove(n - 1);
                c = String.Concat(a, b);
                if (!(box.Contains(c)))
                {
                    box.Add(c); 
                }
            }
            cform = box.Max();
            Console.WriteLine("Canonical form of {0} is {1}",structure, cform);
            box.Clear();
            
        }
    }
}