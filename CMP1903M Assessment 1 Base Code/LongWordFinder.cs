using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class LongWordFinder
    {
        public void LongWord(string input) 
        {
            //Removes all characters that are not 0-9, a-z, or A-Z at least once and replaces them with empty space
            string finder = Regex.Replace(input, @"[^0-9a-zA-Z]+", " ");
            
            //Splits each word into an array
            string [] words = finder.Split(new[] { ' ' }, StringSplitOptions.None);
            string word = "";
            int ctr = 7;
            foreach (string s in words)
            { 
                if (s.Length > ctr)
                {
                    word = s;

                    //Writes words longer than 7 characters to a file
                    using StreamWriter file = new("Longwords.txt");
                    file.WriteLine(word);

                }
            }
        
        }
    }
}
