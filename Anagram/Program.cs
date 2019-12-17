using System;
using System.Threading;
using System.Collections.Generic;
using AnagramCoding;
namespace AnagramCheck
{
    public class Program
    {
        
 static void Main()
        {
            AnagramCode userAna = new AnagramCode();
            Console.WriteLine("Please enter a word to check: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please input words you want to check for anagrams. Enter '-' to end list");
            
            List<string> Anagram = new List<string>();
            string listMaker = Console.ReadLine();
            
            while(listMaker != "-") 
            {
             Anagram.Add(listMaker);
             listMaker = Console.ReadLine();
            }

            //List<string> result =
            foreach(string current in userAna.AnagramChecker(userInput, Anagram))
            {
                Console.WriteLine(current);
            }
        
        

                
        }
    }
}