namespace linq_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sorting using wordLength
            string[] words = { "The", "Quick", "brown", "fox", "Jump" };
            var query = from word in words
                        orderby word.Length
                        select word;
            foreach (var word in query)
            {
                Console.WriteLine(word);
            }

            //sorting from the 1st letter
            string[] words2 = { "The", "Quick", "brown", "fox", "Jump" };
            var query2 = from word in words2
                         orderby word.Substring(0, 1)
                         select word;

            foreach(var word in query2)
            {
                Console.WriteLine(word);
            }

        }

            
    }   
}
