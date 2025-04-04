namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("Please can you input the date and time of the easter break");
            DateTime target = Convert.ToDateTime(Console.ReadLine());
            
            TimeSpan difference = target - current;
            
            Thread.Sleep(1000);
            if (Convert.ToInt32(difference) >= 0)
            {
                Console.WriteLine(difference.TotalDays + " days, " + difference.TotalHours + " hours, " + difference.Minutes + " minutes, " + difference.Seconds + " seconds.");
            }
            else 
            {
                Console.WriteLine("Easter break has already begun - therefore the time will be negative");
                Console.WriteLine(difference.TotalDays + " days, " + difference.TotalHours + " hours, " + difference.Minutes + " minutes, " + difference.Seconds + " seconds.");
            }
        
        }
    }
}
