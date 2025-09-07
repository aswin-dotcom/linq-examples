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

            Console.WriteLine("Sorting using wordLength");
            foreach (var word in query)
            {
                Console.WriteLine(word);
            }

            //sorting from the 1st letter
            string[] words2 = { "The", "Quick", "brown", "fox", "Jump" };
            var query2 = from word in words2
                         orderby word.Substring(0, 1)
                         select word;
            Console.WriteLine("Sorting using First Letter");
            foreach (var word in query2)
            {
                Console.WriteLine(word);
            }

            //union operation
            int[] union1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] union2 = { 10, 11, 12, 6, 7 };
            var unionquery=from num in union1.Union(union2)
                        select num;
            Console.WriteLine("Union");
            foreach(var num in unionquery)
            {
                Console.WriteLine(num);
            }
            // insert operation
            int[] insert1 = { 1, 2, 3, 4, 5 };
            int[] insert2 = { 1, 2, 3 };
            var insertquery = from num in insert1.Intersect(insert2)
                              select num;

            Console.WriteLine("Insert");
            foreach (var num in insertquery)
            {
                Console.WriteLine(num);
            }

            // Distinct operation

            int[] distinctarr = { 1, 2, 2, 1, 3, 3, 4, 4, 4 };
            var distinctquery = from num in distinctarr.Distinct()
                                select num;

            Console.WriteLine("Distinct");
            foreach (var num in distinctquery)
            {
                Console.WriteLine($"{num}");
            }
            int[] expectarr = { 1, 2, 3, 4, 5 };
            int[] expectarr2 = { 1, 2, 3 };
            var expectquery =  from num in expectarr.Except(expectarr2)
                               select num;

            Console.WriteLine("Expect");
            foreach( var num in expectquery)
            {
                Console.WriteLine(num);
            }





        }


       


            
    }   
}
