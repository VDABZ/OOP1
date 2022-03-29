//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input choice = new Input();
            Analyse anaylser = new Analyse();
            Report output = new Report();
            Frequency analysis = new Frequency();
            LongWordFinder finder = new LongWordFinder();
            


            while (true)
            {
                Console.WriteLine("To upload a txt file type: upload Or enter the text manually type: manual");
                string decision = Console.ReadLine();
                decision = decision.ToLower();

                if (decision == "upload")
                {
                    Console.WriteLine("Please enter the file name or the location of the path file");
                    string location = Console.ReadLine();
                    string filetext = choice.fileTextInput(location);
                    var results = anaylser.analyseText(filetext);
                    output.UploadOutputConsole(results);
                    analysis.frequencyOfLetters(filetext);
                    
                }

                else if (decision == "manual")
                {
                    Console.WriteLine("Please ensure you add an asteaerrix (*) at the end of each sentence!");
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
