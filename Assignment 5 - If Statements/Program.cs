namespace Assignment_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            string planet;

            // Space Boxing
            Console.WriteLine("Hello, Julio Cesar Chavez Mark VII!");
            Console.Write("Please enter your weight in pounds on Earth: ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus  2. Mars  3. Jupiter");
            Console.WriteLine("4. Saturn  5. Uranus  6. Neptune");
            Console.WriteLine();
            Console.WriteLine("Please enter your destination planet: ");
            planet = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (planet == "venus" || planet == "1") 
            {
                weight = Math.Round(weight * 0.78, 2);
                Console.WriteLine("Your weight on Venus would be " + weight + " pounds");
            }

            else if (planet == "mars" || planet == "2")
            {
                weight = Math.Round(weight * 0.39, 2);
                Console.WriteLine("Your weight on Mars would be " + weight + " pounds");
            }

            else if (planet == "jupiter" || planet == "3")
            {
                weight = Math.Round(weight * 2.65, 2);
                Console.WriteLine("Your weight on Jupiter would be " + weight + " pounds");
            }

            else if (planet == "saturn" || planet == "4")
            {
                weight = Math.Round(weight * 1.17, 2);
                Console.WriteLine("Your weight on Saturn would be " + weight + " pounds");
            }

            else if (planet == "uranus" || planet == "5")
            {
                weight = Math.Round(weight * 1.05, 2);
                Console.WriteLine("Your weight on Uranus would be " + weight + " pounds");
            }

            else if (planet == "neptune" || planet == "6")
            {
                weight = Math.Round(weight * 1.23, 2);
                Console.WriteLine("Your weight on Neptune would be " + weight + " pounds");
            }

            // Worst guessing game ever
        }
    }
}
