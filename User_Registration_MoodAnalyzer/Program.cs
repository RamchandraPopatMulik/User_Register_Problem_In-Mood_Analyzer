namespace User_Registration_MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please Enter Your Name :");
            string name = Console.ReadLine();

            User user = new User();
            user.FirstName(name);
        }
    }
}