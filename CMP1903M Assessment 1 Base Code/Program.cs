//Base code project for CMP1903M Assessment 1

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Create 'Input' object
            //Create an 'Analyse' object
            //Create a 'Report' object
            //Create a 'Frequency' object
            //Create a 'LongWordFinder' object

            Input choice = new Input();
            Analyse analyser = new Analyse();
            Report output = new Report();
            Frequency analysis = new Frequency();
            LongWordFinder finder = new LongWordFinder();

            //Get either manually entered text, or text from a file
            //Lets the user decide the option
            bool run = true;

            while (run)
            {
                Console.WriteLine("To upload a txt file type: upload Or enter the text manually type: manual");
                string? decision = Console.ReadLine();
                decision = decision?.ToLower();
                bool filecheck = true;

                if (decision == "upload")
                {
                    while (filecheck)
                    {
                        Console.WriteLine("Please enter the file name or the location of the path file");
                        string? location = Console.ReadLine();
                        bool fileExits = File.Exists(location);
                        if (fileExits)
                        {
                            if (location == null)
                            {
                                location = "nothing";
                            }
                            string filetext = choice.FileTextInput(location);
                            var results = analyser.AnalyseText(filetext);   //Pass the text input to the 'analyseText' method
                            output.FileOutput(results);
                            analysis.FrequencyOfLetters(filetext);
                            finder.LongWord(filetext);
                            
                            //Allows user to check another piece of text
                            while (true)
                            {
                                Console.WriteLine("Would you like to analyse another piece of text? (Enter yes or no) ");
                                string? again = Console.ReadLine();
                                again = again?.ToLower();

                                if (again == "yes")
                                {
                                    run = true;
                                    filecheck = false;
                                    break;
                                }
                                
                                if (again == "no")
                                {
                                    run = false;
                                    filecheck = false;
                                    break;
                                    
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a correct response! (yes or no) ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("This doesn't exist!"); //If there is no file


                        }

                    }


                }

                else if (decision == "manual")
                {
                    Console.WriteLine("Please ensure you add an asterisk (*) at the end of each sentence! Click enter when complete! ");
                    string manualtext = choice.ManualTextInput();           //Pass the text input to the 'analyseText' method
                    var results = analyser.AnalyseText(manualtext);        //Receive a list of integers back
                    output.OutputConsole(results);                        //Passes the results to Report
                    analysis.FrequencyOfLetters(manualtext);             //Gets the frequency of individual letters

                    //Allows user to check another piece of text
                    while (true)
                    {
                        Console.WriteLine("Would you like to analyse another piece of text? (Enter yes or no) ");
                        string? again = Console.ReadLine();
                        again = again?.ToLower();

                        if (again == "yes")
                        {
                            run = true;
                            break;
                        }

                        if (again == "no")
                        {
                            run = false;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Please enter a correct response! (yes or no) ");
                        }
                    }

                }

                else
                {
                    Console.WriteLine("Please choose a correct method!");
                }

            }

           
        }
        
        
    
    }
}
