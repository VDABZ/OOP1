namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void OutputConsole(List<int> list) 
        {
            Console.WriteLine("The number of sentences are " + list[0]);
            Console.WriteLine("The number of vowels are " + list[1]);
            Console.WriteLine("The number of cons are " + list[2]);
            Console.WriteLine("The number of uppercase letters are " + list[3]);
            Console.WriteLine("The number of lowercase letters are " + list[4]);

        }

        public void FileOutput(List<int> list)
        {
            //Writes the anaylse to a text file if text file was chosen
            using StreamWriter file = new("Report.txt");
            file.WriteLine("The number of sentences are " + list[0]);
            file.WriteLine("The number of vowels are " + list[1]);
            file.WriteLine("The number of cons are " + list[2]);
            file.WriteLine("The number of uppercase letters are " + list[3]);
            file.WriteLine("The number of lowercase letters are " + list[4]);

        }
    }
}
