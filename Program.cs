namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many Small Carpers do you need.");
            //int smallCarpet =int.Parse(Console.ReadLine());
            //Console.WriteLine("How many Large Carpers do you need.");
            //int largeCarpet =int.Parse(Console.ReadLine());
            //Console.WriteLine("Price per Small room is 25$. \nPrice per Large room is 35$.");
            //Console.WriteLine($"Costs : {smallCarpet*25+largeCarpet*35}");
            //Console.WriteLine($"tax :{(smallCarpet * 25 + largeCarpet * 35) * .06}");
            //Console.WriteLine($"total stimate :{((smallCarpet * 25 + largeCarpet * 35) * .06) + (smallCarpet * 25 + largeCarpet * 35)}");
            //Console.WriteLine("This estimate is valid for 30 days.");

            //another solution

            Console.WriteLine("How many Small Carpers do you need.");
            int smallCarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Large Carpers do you need.");
            int largeCarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("Price per Small room is 25$. \nPrice per Large room is 35$.");
            int totalCarpet = smallCarpet * 25 + largeCarpet * 35;
            float tax = totalCarpet * .06f;
            Console.WriteLine($"");
            Console.WriteLine($"Costs :{totalCarpet :C} \ntax :{tax:C} \nTotal Estimate :{totalCarpet + tax :C} \nThis estimate is valid for 30 days.");





        }
    }
}
