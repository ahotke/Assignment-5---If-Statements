namespace Assignment_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, scorePercentage;
            string planet, name, trueFalse, answer;
            int secretNumber = 6, guess, score = 0;

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
            else
                Console.WriteLine("Invalid input!");
            Console.WriteLine();

            // Worst guessing game ever
            Console.WriteLine("Let's play a game!");
            Console.WriteLine("I chose a number between 1 and 10, can you guess it?");
            Console.Write("Your guess: ");
            Int32.TryParse(Console.ReadLine(), out guess);
            if (guess == secretNumber)
                Console.WriteLine("You guessed my secret number!");
            else if (guess > secretNumber)
                Console.WriteLine("Your guess is too high! My number was " + secretNumber);
            else if (guess < secretNumber)
                Console.WriteLine("Your guess is too low! My number was " + secretNumber);
            Console.WriteLine();

            guess = 0;

            Console.WriteLine("Time for a quiz!");
            Console.WriteLine("Question 1: Say my name");
            name = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (name == "heisenberg")
            {
                Console.WriteLine("You're right.");
                score += 1;
            }
            else
                Console.WriteLine("You're wrong. My name is Heisenberg");
            Console.WriteLine();

            Console.WriteLine("Question 2: How many planets are in our solar system?");

            Int32.TryParse(Console.ReadLine(), out guess);

            if (guess == 8) {
                Console.WriteLine("Correct! We have 8 planets in our solar system.");
                score += 1;
            }

            else if (guess != 8)
                Console.WriteLine("That's incorrect! There are 8 planets in our solar system.");

            Console.WriteLine();

            Console.WriteLine("Question 3: True or False? Apples are blue");
            trueFalse = Console.ReadLine().ToLower();

            if (trueFalse == "true")
                Console.WriteLine("Apples aren't blue!");

            else if (trueFalse == "false") {  
                Console.WriteLine("Correct! Apples are not blue!");
                score += 1;
                }

            else
                Console.WriteLine("I said true or false, not whatever " + trueFalse + " is!");

            Console.WriteLine();

            Console.WriteLine("Question 4: Roses are red, violets are");
            Console.WriteLine("A. Green");
            Console.WriteLine("B. Yellow");
            Console.WriteLine("C. Blue");
            Console.WriteLine("D. Violet");

            answer = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (answer == "a" || answer == "green")
            {
                Console.WriteLine("Violets aren't green! They are blue!");
            }

            else if (answer == "b" || answer == "yellow")
            {
                Console.WriteLine("That's not how the sentence ends! They are blue!");
            }

            else if (answer == "c" || answer == "blue")
            {
                Console.WriteLine("Correct!");
                score += 1;
            }

            else if (answer == "d" || answer == "violet")
            {
                Console.WriteLine("That's technically correct, but that's not how the sentence ends.");
            }

            else
                Console.WriteLine("Invalid input!");

            Console.WriteLine();

            scorePercentage = ((double)score / 4) * 100;

            Console.WriteLine("You got a score of " + score + "/4. That is " + scorePercentage + "%.");









        }
    }
}
