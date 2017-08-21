using System;
namespace GrandCircus
{
	class Program
	{
		static void Main(string[] args)
		{
			int digit1number1 = 0; // 1st digit of first number entered by user
			int digit2number1 = 0; // 2nd digit of first number entered by user
			int digit3number1 = 0; // 3rd digift of first number entered by user
			int digit1number2 = 0; // 1st digit of second number entered by user
			int digit2number2 = 0; // 2nd digit of second number entered by user
			int digit3number2 = 0; // 3rd digit of second number entered by user
			int sum1 = 0;
			int sum2 = 0;
			int sum3 = 0;
			Console.WriteLine("Type any three digit number below:"); /// the first number entered by the user
			String firstInput = Console.ReadLine();
			Int32 number1 = Convert.ToInt32(firstInput);
			while (!Int32.TryParse(firstInput, out int firstOutput)) //integer validation
			{ Console.WriteLine("Not a valid 3-digit number, try again."); }
			Console.WriteLine("Thanks! Now, please type a second three-digit number of choice below:"); // request the second number of the user
			String secondInput = Console.ReadLine();
			Int32 number2 = Convert.ToInt32(secondInput);
			digit1number1 = (number1 % 10); // 1st digit of first number
			digit2number1 = (number1 / 10) % 10; // 2nd digit of first number
			digit3number1 = (number1 / 100); // 3rd digit of first number
			digit1number2 = (number2 % 10); // 1st digit of second number 
			digit2number2 = (number2 / 10) % 10; //2nd digit of second number
			digit3number2 = (number2 / 100); // 3rd digit of second number
			Console.WriteLine("Now press return to get your digits of each number submitted.");
			Console.ReadKey();
			Console.WriteLine("{0} - > {1}, {2}, {3}", number1, digit3number1, digit2number1, digit1number1);
			Console.ReadKey();
			Console.WriteLine("{0} - > {1}, {2}, {3}", number2, digit3number2, digit2number2, digit1number2);
			Console.ReadKey();

			Console.WriteLine("Now, if each first, second, and third digit is equal to each other you will receive a 'true' if not it will return with a 'false' .");
			Console.ReadKey();
			var Program = new Program();

			//boolean condition // comparison variable
			sum1 = (digit1number1 + digit1number2); // Add digit 1 of number 1 and number 2
			sum2 = (digit2number1 + digit2number2); // Add digit 2 of number 1 and number 2
			sum3 = (digit3number1 + digit3number2); // Add digit 3 of number 1 and number 2
			bool a = (sum1 == sum2 && sum2 == sum3);
			bool b = (sum1 != sum2 && sum2 == sum3);
			bool c = (sum1 == sum2 && sum2 != sum3);
			Console.WriteLine(a);
		}
	}
}
