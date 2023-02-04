
using System;
using System.Collections.Generic;
using System.Linq;


namespace am20001382_Project
{

    internal partial class Program
    {
        static int n;

        
            static void Gen(List<string> structures) //Generates all structures of "n"
            {

                Console.WriteLine("Enter 'n' value:");
                n = Convert.ToInt32(Console.ReadLine());
                int k = (n - 2), l = (n + 0), x = 0, max = Pow(k, n);
                string str;
                Random rnd = new Random();
                List<string> combInts = structures;
                for (str = "", x = 0; combInts.Count < max; str = "", x = 0)
                {
                    while (x < n)
                    {
                        int num = rnd.Next(2, l);
                        str = String.Concat(str, Convert.ToString(num));
                        x++;
                    }

                    if (!(combInts.Contains(str)))
                    {
                        combInts.Add(str);
                        Console.WriteLine(str);
                    }

                }

                Console.WriteLine("List should contain {0} elements", max);
                Console.WriteLine("List Contains {0} elements", (combInts.Count));
            }

            static int Pow(int x, int y)
            {
                int num = 1;
                while (y > 0)
                {
                    num *= x;
                    y--;
                }

                return num;
            }

            static void
                EqClass(List<string> structures) // determines the number of equivelance classes of all structures of "n"
            {
                List<string> box = new List<string>(); //temporarily hold all forms of a structure
                List<string>
                    bigstructs = new List<string>(); //holds canonical form of each set of equivalent structures
                List<string> structs = structures;
                string a, b, c, cform;
                int classcount = 0;
                for (int x = 0; x < structs.Count; x++, box.Clear())
                {
                    c = structs[x];
                    int n = c.Length; //length of the current structure being worked on
                    for (int i = 0; i < n; i++) //create all forms of the current structure and stores in the "box" list
                    {
                        a = Convert.ToString(c.Last());
                        b = c.Remove(n - 1);
                        c = String.Concat(a, b);
                        box.Add(c);
                    }

                    cform = box.Max();
                    //Console.WriteLine("cform {0}: {1}", x, cform);
                    if (!(bigstructs.Contains(cform)))
                    {
                        bigstructs.Add(
                            cform); //adds the canonical form of each set of equivalent structures to the structs List
                        classcount++;
                    }
                    //Console.WriteLine(bigstructs.Last());
                }

                //Console.WriteLine("There are {0} equivalence classes", classcount);
                Console.WriteLine("There are {0} equivalence classes for structures of size {1}", classcount, n);
            }
            static void Q4(List<string> structures)
            {
                List<string> structs = structures;
                Gen(structs);
                EqClass(structs);
            }
    }
}