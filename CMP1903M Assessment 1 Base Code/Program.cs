//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Summary of review
 * See comments for information and suggestions, overall the code is very well written however there is still a lot more to do.
 * The code runs well, it just needs more information for the user on what to do as it is very confusing.
 * WWW
 * Variables names are concise and very clear although some lack detail
 * 
 */



namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            
            //This hasn't been used - consider removing if you're not going to use it. 
            
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input choice = new Input();
            
            //typo - analyser

            Analyse anaylser = new Analyse();
            Report output = new Report();
            Frequency analysis = new Frequency();
            LongWordFinder finder = new LongWordFinder();
            


            while (true)
            {
                Console.WriteLine("To upload a txt file type: upload Or enter the text manually type: manual");
                
                //string? to say it could be a string or a null value to prevent errors if there is a null value returned from readline
                 
                string? decision = Console.ReadLine(); //This could be a null value. Do this to prevent this from happening:
                
                //removes errors if null.
                string test = Console.ReadLine()!;
                
                decision = decision?.ToLower();

                if (decision == "upload")
                {
                    Console.WriteLine("Please enter the file name or the location of the path file");
                    string location = Console.ReadLine(); // again null possible 
                    //should be fileText - camel Casing 
                    string filetext = choice.fileTextInput(location);
                    var results = anaylser.analyseText(filetext);
                    output.UploadOutputConsole(results);
                    analysis.frequencyOfLetters(filetext);
                    
                }

                else if (decision == "manual")
                {
                    
                    //typo - asterisk 
                    
                    Console.WriteLine("Please ensure you add an asteaerrix (*) at the end of each sentence!");
                    
                    // typo  - manualText reads better. 
                    
                    string manualtext = choice.manualTextInput();
                    var results = anaylser.analyseText(manualtext);
                    output.ManualOutputConsole(results);
                    analysis.frequencyOfLetters(manualtext);
                    finder.LongWord(manualtext);

                }

                else
                {
                    Console.WriteLine("Please choose a correct method!");
                }

            }
            


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
