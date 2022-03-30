namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            //Removes all the empty spaces in input
            input = input.Replace(" ", string.Empty);
            
            bool presence = false;

            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            int sentences = 0;
            int vowel = 0;
            int consonant = 0;
            int uppercase = 0;
            int lowercase = 0;

            string[] vowels = { "A", "E", "I", "O", "U" };
            string[] consonants = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "X", "Z", "W", "Y" };
            
            
            foreach (char c in input)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (vowels[i] == c.ToString())
                    {
                        vowel++;
                        uppercase++;
                        presence = true;
                    }

                    string lowerVowel = vowels[i].ToLower();
                    if (lowerVowel == c.ToString())
                    {
                        vowel++;
                        lowercase++;
                        presence = true;
                    }
                }
                
                for (int j = 0; j < consonants.Length; j++) 
                {
                    if (consonants[j] == c.ToString())
                    {
                        consonant++;
                        uppercase++;
                        presence=true;

                    }
                    
                    string lowerConsonant = consonants[j].ToLower();
                    if (lowerConsonant == c.ToString()) 
                    {
                        consonant++;
                        lowercase++;
                        presence=true;

                    }
                    
                    
                }
                
                //This will only run if consonants or vowels are present in input
                if (c.ToString() == "*")
                {   
                    if (presence == true)
                    {
                        sentences++;
                    }
                }
            }









            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            //Initialise all the values in the list to '0'
            List<int> values = new List<int>();
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            
            //Replaces all the values in list with the analysis values
            values[0] = sentences;
            values[1] = vowel;
            values[2] = consonant;
            values[3] = uppercase;
            values[4] = lowercase;
            return values;
        }
    }
}
