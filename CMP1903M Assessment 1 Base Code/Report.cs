namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void ManualOutputConsole(List<int> list) 
        {
            Console.WriteLine("The number of setences are " + list[0]);
            Console.WriteLine("The number of vowels are " + list[1]);
            Console.WriteLine("The number of cons are " + list[2]);
            Console.WriteLine("The number of uppercase letters are " + list[3]);
            Console.WriteLine("The number of lowercase letters are " + list[4]);

        }

        public void UploadOutputConsole(List<int> list)
        {
            using StreamWriter file = new("Report.txt");
            
            file.WriteLine("The number of setences are " + list[0]);
            file.WriteLine("The number of vowels are " + list[1]);
            file.WriteLine("The number of cons are " + list[2]);
            file.WriteLine("The number of uppercase letters are " + list[3]);
            file.WriteLine("The number of lowercase letters are " + list[4]);

        }
    }
}
