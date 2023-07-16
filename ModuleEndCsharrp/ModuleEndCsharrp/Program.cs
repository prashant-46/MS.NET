namespace ModuleEndCsharrp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            
            Console.Write("\n The days of a week : ");
            Console.Write("\n------------------------------------------------");
            Console.Write("\n------------------------------------------------\n");


            var days = from Days in weekdays
                       select Days;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();
        }
    }
}