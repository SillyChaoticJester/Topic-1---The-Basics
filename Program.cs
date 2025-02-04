namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Miracle McMahon   
            string firstName = "Miracle";
            string favMovie = "The Matrix";
            string favQuote = "Uh oh! Bad decision, Mark!";
            favMovie = favMovie.ToUpper();
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            favQuote = favQuote.Replace("a", "");
            favQuote = favQuote.Replace("A", "");
            favQuote = favQuote.Replace("e", "");
            favQuote = favQuote.Replace("E", "");
            favQuote = favQuote.Replace("i", "");
            favQuote = favQuote.Replace("I", "");
            favQuote = favQuote.Replace("o", "");
            favQuote = favQuote.Replace("O", "");
            favQuote = favQuote.Replace("u", "");
            favQuote = favQuote.Replace("U", "");

            Console.WriteLine($"My name is {firstName.ToLower()} and my favorite movie is {favMovie}");
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine(favQuote);
        }
    }
}
