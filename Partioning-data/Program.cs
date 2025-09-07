namespace Partioning_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] list1 = {1, 2, 3,4,5};
            //var query = list1.Skip(3);
            //var query = list1.SkipWhile(i => i != 3);
            //var query = list1.Take(3);
            var query = list1.TakeWhile(i => i != 3);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }


        }
    }
}
