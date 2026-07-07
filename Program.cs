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
            ///Task6\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 6 ---");
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8 && !password.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");

                if (password.Length < 8)
                {
                    Console.WriteLine("Reason: Less than 8 characters.");
                }

                if (password.ToLower().Contains("password"))
                {
                    Console.WriteLine("Reason: Contains the word 'password'.");
                }
            }
            ///Task7\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 7 ---");
            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine().Trim().ToUpper();

            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine().Trim().ToUpper();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            ///Task8\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 8 ---");
            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter membership days: ");
                int days = Convert.ToInt32(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(days);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership Status: Active");
                }
                else
                {
                    Console.WriteLine("Membership Status: Expired");
                }

                Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }




