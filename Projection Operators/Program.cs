namespace Projection_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[] { "an", "apple", "a", "day" };
            var query = from word in words
                        select word.Substring(0, 1);


            foreach (var word in query)
            {
                Console.WriteLine(word);
            }


            var wordarr = new string[] { " Aswin  is  a Good Boy", "Aswin is the software engineer" };

             var queryarr = from wors  in wordarr
                            from word in wors.Split(' ')
                            select word;
            foreach (var word in queryarr)
            {
                Console.WriteLine($"{word}");
            }

        }
    }
}
