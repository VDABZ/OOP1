using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class LongWordFinder
    {
        public void LongWord(string input) 
        {
            string finder = Regex.Replace(input, @"[^0-9a-zA-Z]+", " ");
            Console.WriteLine(finder);
            string [] words = finder.Split(new[] { ' ' }, StringSplitOptions.None);
            string word = "";
            int ctr = 7;
            foreach (string s in words)
            { 
                if (s.Length > ctr)
                {
                    word = s;
                    using StreamWriter file = new("Longwords.txt");
                    file.WriteLine(word);
                }
            }
        
        }
    }
}
