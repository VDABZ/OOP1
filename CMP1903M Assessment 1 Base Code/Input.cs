namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string _text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string ManualTextInput()
        {
            Console.WriteLine("Please manually type your text!");
            string? text = Console.ReadLine();
            if (text == null) 
            {
                text = string.Empty;
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string fileName)
        {
            string text = File.ReadAllText(fileName);
            if (text == null) 
            { 
                text = string.Empty;
            }
           
            return text;
            
        }

    }
}
