using System;
using System.Linq;
using System.Collections.Generic;
namespace am20001382_Project
{
    internal partial class Program
    {
        public static void Q2(List<string> structs)
        { 
            
            List<string> box = new List<string>(); //temporarily hold all forms of a structure
            List<string> structures = structs;
            string a, b, c;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter structure {0}", (i + 1));
                structures.Add(Console.ReadLine());
            }
            for (int x = 0; x < 1; x++)
            {
                c = structures[x];
                int n = c.Length; //length of the current structure being worked on
                for (int i = 0; i < n; i++) //create all forms of the current structure and stores in the "box" list
                {
                    a = Convert.ToString(c.Last());
                    b = c.Remove(n - 1);
                    c = String.Concat(a, b);
                    box.Add(c);
                }
            }
            Console.WriteLine(box.Contains(structures[1])
                ? "Structures are equivalent."
                : "Structures are Not equivalent.");
            structs.Clear();
            structures.Clear();
        }
    }
}