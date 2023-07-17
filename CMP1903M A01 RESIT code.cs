using System;

public class testScore
{
	
	public static void Main()
	{
	
		string str1;
		double dbl1;

		Console.WriteLine("Welcome to the Acme Student Test Score comenter");

		Console.WriteLine("Enter your name");
		str1 = Console.ReadLine();

		Console.WriteLine("Enter the test score");
		dbl1 = Double.Parse(Console.ReadLine());

		Console.WriteLine("Hello {0}", str1);
		Console.WriteLine("You scored {0}", dbl1);

		if(dbl1 < 40)
		{
			if (dbl1 > 0)
			{ 
				Console.WriteLine("This a FAIL score");
			}
		}
		if ((dbl1 >= 40) && (dbl1 <= 100))
		{
			Console.WriteLine("This is a PASS score");

			if (dbl1 >= 75)
				Console.WriteLine("You did very well!");
		}
		else
		{
			Console.WriteLine("Oh dear - you have put in a wrong test score");
		}
	} 
}