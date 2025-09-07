namespace Zip_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = { 1, 2, 3 };
            string[] text = { "A", "B", "C" };
            var query =  Enumerable.Zip(list1, text ,(number,letter)=>number.ToString()+letter);
            foreach(string i in query)

            {
                Console.WriteLine(i);
            }
        }
    }
}
