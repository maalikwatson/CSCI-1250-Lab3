namespace AverageScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt user to input three homework scores
            Console.Write("Please enter score 1: ");
            double score1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter score 2: ");
            double score2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter score 3: ");
            double score3 = Convert.ToDouble(Console.ReadLine());

            // calculate the average of test scores
            double average = (score1 + score2 + score3) / 3;

            // print average to the console
            Console.WriteLine("Your average score is " + Math.Round(average, 2) + ".");

            // if statement that prints string data under explict conditions
            if (average > 95.00)
            {
                Console.WriteLine("That's a great score!");
            }

            Console.ReadKey();
        }
    }
}
