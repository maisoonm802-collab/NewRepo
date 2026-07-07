namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            Console.WriteLine("Positive Difference: " + difference);
///Task2\\\\\\\\\\\\\\\\\\\\\\\\\\\\
Console.WriteLine("\n--- Task 2 ---");
 Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double root = Math.Sqrt(number);

            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + root);
            ///Task3\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 3 ---");
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Character Count: " + name.Length);
            ///Task4\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 4 ---");
            Console.Write("Enter free trial days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(days);

            Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));
            ///Task5\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 5 ---");
            Console.Write("Enter your exam score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(score);

            Console.WriteLine("Rounded Score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }













