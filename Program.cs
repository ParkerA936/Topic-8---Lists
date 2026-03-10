namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part5();
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
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(i + ". " + names[i]);
            //}



        }
        public static void Part2()
        {
            Random generator = new Random();
            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith", "Tank" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine(names[0]); // This prints out the first element
            Console.WriteLine("There are " + names.Count + " names in my array.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");

            // Change the last name without hard coding an index number
            names[names.Count - 1] = "Cypher";
            Console.WriteLine(names[names.Count - 1] + " is another bad guy.");

            // Random Challenge
            Console.WriteLine();
            Console.WriteLine("Here is a random name:");
            Console.WriteLine(names[generator.Next(names.Count)]);
            Console.WriteLine();

            // Prints all elements no matter what the size of the array is
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

            // Prints all elements without using a loop
            Console.WriteLine(string.Join(", ", names));
        }
        public static void Part3()
        {
            Random generator = new Random();
            List<int> numbers = new List<int> { 3, 9, 27, 81, 243 };
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[1] + numbers[3]);
            Console.WriteLine(numbers[1 + 3]);
            Console.WriteLine(numbers[4]);
            Console.ReadLine();



        }
        public static void Part4()
        {
            int biggerThanFive= 0;
            List<int> numbers = new List<int>(); // Creates an empty List
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Press ENTER to continue:");

            Console.ReadLine(); // Keeps the program from ending
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + numbers.Average());
            Console.WriteLine();
            for (int i = numbers.Count - 1; i >= 0; i--) // We start at the last index (Length-1) and end at zero.
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers larger than 5 are:");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 5)
                {
                    Console.Write(numbers[i] + " ");
                    biggerThanFive += 1;    // Counts the number of values bigger than 5 challenge
                }
            }
            Console.WriteLine("There are "+biggerThanFive+ " numbers bigger than five.");    
        }

        public static void Part5()
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();
            int zeroCount = 0;

            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(41));
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("The average is " + numbers.Average());
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());

            // Prints words for multipes of ten
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 10)
                    Console.Write("Ten ");
                else if (numbers[i] == 20)
                    Console.Write("Twenty ");
                else if (numbers[i] == 30)
                    Console.Write("Thirty ");
                else if (numbers[i] == 40)
                    Console.Write("Fourty ");
                else
                    Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Double List");
            for (int i = 0; i < numbers.Count; i++)
                numbers[i] = numbers[i] * 2;
            Console.WriteLine("Set values < 50 to zero");
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] < 50)
                    numbers[i] = 0;
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("Challenge - Count Zeroes");
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] == 0)
                    zeroCount += 1;
            Console.WriteLine("There are " + zeroCount + " zeroes");
        }
    }
}
