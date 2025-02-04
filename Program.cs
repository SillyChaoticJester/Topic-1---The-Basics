namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Miracle McMahon   
            string firstName = "Miracle";
            string favMovie = "The Matrix";
            
            Console.WriteLine($"My name is {firstName.ToLower()} and my favorite movie is {favMovie}");
            Console.WriteLine(favMovie.Contains("THE"));
        }
    }
}
