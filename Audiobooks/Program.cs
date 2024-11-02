namespace Audiobooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the letter of the Audiobooks package you purchased (A,B,or C): ");
            char packageLetter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the number of Audiobooks that you've read: ");
            int numBooks = Convert.ToInt32(Console.ReadLine());

            const double BaseA = 9.95;
            const double BooksA = 2.00;

            const double BaseB = 13.95;
            const double BooksB = 1.00;

            const double BaseC = 19.95;

            double totalCharges = 0.00;


            if (packageLetter == 'A' && numBooks <= 10 || packageLetter == 'a' && numBooks <= 10)
            {
                totalCharges = BaseA;
            }
            else if (numBooks > 10)
            {
                totalCharges = ((numBooks - 10) * BooksA) + BaseA;
            }
            if (packageLetter == 'B' && numBooks <= 20 || packageLetter == 'b' && numBooks <= 20)
            {
                totalCharges = BaseB;
            }
            else if (numBooks > 20)
            {
                totalCharges = ((numBooks - 20) * BooksB) + BaseB;
            }
            if (packageLetter == 'C' || packageLetter == 'c')
            {
                totalCharges = BaseC;
            }


            Console.WriteLine("");
            Console.WriteLine("Total charges for " + numBooks + " books for plan " + packageLetter + " is " + Math.Round(totalCharges, 2));

            Console.ReadKey();
        }
    }
}
