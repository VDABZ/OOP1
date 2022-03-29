using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Frequency
    {
        public void frequencyOfLetters(string input)
        {
            
            //just a dictionary - not a method or class - should be just alphabet ass the name for this dictionary as it looks like a class etc
            

            //This could be made shorter by looping through the ASCII characters and initialising the dictionary with them although this method works just as well. 
            
            Dictionary<string, int> Alphabet = new Dictionary<string, int>()
            {
            {"a", 0},
            {"b", 0},
            {"c", 0},
            {"d", 0},
            {"e", 0},
            {"f", 0},
            {"g", 0},
            {"h", 0},
            {"i", 0},
            {"j", 0},
            {"k", 0},
            {"l", 0},
            {"m", 0},
            {"n", 0},
            {"o", 0},
            {"p", 0},
            {"q", 0},
            {"r", 0},
            {"s", 0},
            {"t", 0},
            {"u", 0},
            {"v", 0},
            {"w", 0},
            {"x", 0},
            {"y", 0},
            {"z", 0},
            };

            input = input.ToLower();
            
            //This can be converted into a LINQ statement to reduce size  - Example below 
            
            foreach (var letter in input.Select(l => l.ToString()).Where(letter => Alphabet.ContainsKey(letter)))
            {
                Alphabet[letter]++;
            }
            

            foreach (char l in input)
            {
                string letter = l.ToString();
                if (Alphabet.ContainsKey(letter))
                {
                    Alphabet[letter]++;
                }
            }

            //The same can be done here - there is also a marginal increase in performance with this as well as you're not looping through it.
            //LINQ is arguably already well optimised.
            
            
            foreach (var value in Alphabet)
                if (value.Value > 0)
                {

                    Console.WriteLine("Letter: {0}, Frequency: {1}", value.Key, value.Value);

                }
            
        }
    }
}
