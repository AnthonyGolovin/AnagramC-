using System;
using System.Threading;
using System.Collections.Generic;

namespace AnagramCoding {

    public class AnagramCode
    {
        List<string> Anagram = new List<string>();

        public List<string> AnagramChecker(string word, List<string> check)
        {
            char[] wordSplit = word.ToCharArray();
            Array.Sort(wordSplit);
            string wordSorted = new string(wordSplit);
            for(int i = 0; i < check.Count;i++)
            {
                char[] checkSplit = check[i].ToCharArray();
                Array.Sort(checkSplit);
                string checkSorted = new string (checkSplit);
                if (wordSorted==checkSorted)
                    Anagram.Add(check[i]);
            }
            return Anagram;
        }

    }


     

}