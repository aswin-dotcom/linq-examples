namespace Filter_and_Quantifier_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            //Filters
            string[] name = { "Aswin", "sherin" };
            var namequery =  from  word in name
                             where word == "Aswin"
                             select word;
            foreach (var word in namequery)
            {
                Console.WriteLine(word);
            }

            var namesquery  =  from word in name
                               where word.Length == 6  && word.StartsWith("s")
                               select word;
            foreach (var word in namesquery)
            {
                Console.WriteLine(word);
            }

            //Quantifier Operations

            var market = new[] { new { MarketPlace = "santhai", fruits = new[] { "kiwi", "Cheri", "Banana" } } ,
            new{MarketPlace="Market" ,fruits= new[]{"Melon","Mango","Olive"} },
            new{MarketPlace="Swiggy" ,fruits= new[]{"kiwi","Apple","Orange"}}
            
            };

            var maket = from mar in market
                        where mar.fruits.All(fruit => fruit.Length == 5)
                        select mar.MarketPlace;

            var met = from mar in market
                        where mar.fruits.Any(fruit => fruit == "kiwi")
                        select mar.MarketPlace;
            var mets = from mar in market
                      where mar.fruits.Contains( "kiwi")
                      select mar.MarketPlace;
            foreach (var mar in mets)
            {
                Console.WriteLine(mar);
            }






        }
    }
}
