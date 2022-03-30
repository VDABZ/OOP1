namespace CMP1903M_Assessment_1_Base_Code
{
    public class Frequency
    {
        public void FrequencyOfLetters(string input)
        {
            // All the words in the alphabet
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
            foreach (var letter in input.Select(l => l.ToString()).Where(letter => Alphabet.ContainsKey(letter)))
            {
                Alphabet[letter]++;
            }

            foreach (var value in Alphabet)
                if (value.Value > 0)
                {

                    Console.WriteLine("Letter: {0}, Frequency: {1}", value.Key, value.Value);

                }

        }
    }
}
