using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        
        //Should be _text as it's a private var. 
        
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        
        //This should be ManualTextInput as it's a method. Methods and classes always start with a capitla letter under the camel casing rules
        
        public string manualTextInput()
        {
            
            Console.WriteLine("Please manually type your text!");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        
       // Same as above - this should be FileTextInput.  
        
        public string fileTextInput(string fileName)
        {
            text = File.ReadAllText(fileName);
            
            //This could be returned as a null which may cause errors so you could be if text == null then do something if not return. Consider using a try catch 
            return text;
        }

    }
}
