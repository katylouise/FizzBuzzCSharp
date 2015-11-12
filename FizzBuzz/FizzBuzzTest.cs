using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture ()]
	public class FizzBuzzTest
	{
		FizzBuzz fb;

		[SetUp]
		public void FizzBuzzCreation ()
		{
			fb = new FizzBuzz ();
		}

		[Test ()]
		public void Print_Number_If_Not_Multiple_Of_Three_Or_Five ()
		{
			Assert.AreEqual (fb.Check ("7"), "7");
		}

		[Test ()]
		public void Print_Fizz_For_Multiple_Of_Three ()
		{
			Assert.AreEqual (fb.Check ("12"), "fizz");
		}

		[Test ()]
		public void Print_Buzz_For_Multiple_Of_Five ()
		{
			Assert.AreEqual (fb.Check ("20"), "buzz");
		}

		[Test ()]
		public void Print_FizzBuzz_For_Multiple_Of_Three_And_Five ()
		{
			Assert.AreEqual (fb.Check ("30"), "fizzbuzz");
		}
	}
}


