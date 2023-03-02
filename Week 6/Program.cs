using System;
using System.Collections.Generic;
namespace Week_6

{
    internal class Program
    {

        static void Main(string[] args)
        {
            problem1(); 
            problem2();
        }
        static void problem1()
        {
             
                var names = new List<string>();

                while (true)
                {
                    var name = AskForName();

                    if (string.IsNullOrEmpty(name))
                        break;

                    names.Add(name);
                    Console.WriteLine(GetLikesMessage(names));
                }
            }

             static string AskForName()
            {
                Console.WriteLine("Enter a name: (Leave it empty to close the program)");
                return Console.ReadLine();
            }

             static string GetLikesMessage(List<string> names)
            {
                if (names.Count > 2)
                    return names[0] + ", " + names[1] + " and " + GetExtraLikes(names).Count + " liked your post";
                if (names.Count == 2)
                    return names[0] + " and " + names[1] + " liked your post";

                return names[0] + " liked your post";
            }

             static List<string> GetExtraLikes(List<string> names)
            {
                return names.GetRange(2, names.Count - 2);
            }
                
            static void problem2()
        {
            string str = "saintseiya";
            char[] strChars = str.ToArray();
            int[] cntr = new int[str.Length];
            int i = 0;
            string retString = string.Empty;

            foreach (char c in str)
            {
                cntr[i] = countChars(c, str);
                i++;
            }

            i = 0;

            foreach (int j in cntr)
            {
                retString += strChars[i] + " Occurs " + j + " times" + "\n";
                i++;
            }

            Console.WriteLine(retString);
            Console.Read();
        }

        static int countChars(char c, string str)
        {
            int cntr = 0;

            foreach (char cNew in str)
            {
                if (c == cNew) cntr++;
            }

            return cntr;
        }

    }
}
        
    

     
    

      
          