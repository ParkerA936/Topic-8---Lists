namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
        }
        public static void Part1()
        {
            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.ReadLine(); // Keeps program from closing




        }
    }
   
} 
