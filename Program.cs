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

            Console.Write("/\\                 /\\\r\n/ \\'._   (\\_/)   _.'/ \\\r\n|.''._'--(o.o)--'_.''.|\r\n \\_ / `;=/ \" \\=;` \\ _/\r\n   `\\__| \\___/ |__/`\r\n        \\(_|_)/\r\n         \" ` \"");
            Console.WriteLine("                                         /\r\n                        _,.------....___,.' ',.-.\r\n                     ,-'          _,.--\"        |\r\n                   ,'         _.-'              .\r\n                  /   ,     ,'                   `\r\n                 .   /     /                     ``.\r\n                 |  |     .                       \\.\\\r\n       ____      |___._.  |       __               \\ `.\r\n     .'    `---\"\"       ``\"-.--\"'`  \\               .  \\\r\n    .  ,            __               `              |   .\r\n    `,'         ,-\"'  .               \\             |    L\r\n   ,'          '    _.'                -._          /    |\r\n  ,`-.    ,\".   `--'                      >.      ,'     |\r\n . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'\r\n ||:, .           ,'  ;  /  / \\ `        `.    .      .'/\r\n j|:D  \\          `--'  ' ,'_  . .         `.__, \\   , /\r\n/ L:_  |                 .  \"' :_;                `.'.'\r\n.    \"\"'                  \"\"\"\"\"'                    V\r\n `.                                 .    `.   _,..  `\r\n   `,_   .    .                _,-'/    .. `,'   __  `\r\n    ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .\r\n   /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |\r\n  .   _  `\"\"'--.._____..--\"   ,             '         |\r\n  | .\" `. `-.                /-.           /          ,\r\n  | `._.'    `,_            ;  /         ,'          .\r\n .'          /| `-.        . ,'         ,           ,\r\n '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'\r\n `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--'     ");
        }
    }
}
