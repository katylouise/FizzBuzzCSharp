using System;

namespace FizzBuzz
{
	class FizzBuzz
	{
		public string Check (string number) {
			int user_number = Int32.Parse(number);

			if (user_number % 15 == 0) 
			{
				return "fizzbuzz";
			}
			else if (user_number % 3 == 0) 
			{
				return "fizz";
			}
			else if (user_number % 5 == 0) 
			{
				return "buzz";
			}
			else 
			{
				return number;
			}
		}

		public static void Main ()
		{
			FizzBuzz fb = new FizzBuzz ();
			Console.WriteLine ("Enter a number: ");
			string input = Console.ReadLine ();
			string num = fb.Check (input);
			Console.WriteLine ("Your number is {0}", num);
		}
	}
}
