using System;

public class testScore
{
	
	public static void Main()
	{
	
		string str1;
		double dbl1;

		Console.WriteLine("Welcome to the Acme Student Test Score comenter");

		Console.WriteLine("Enter your name");
		//reads what youve inputed and stores it into the string
		str1 = Console.ReadLine();

		Console.WriteLine("Enter the test score");
		//reads the score and stores it into the double after converting
		dbl1 = Double.Parse(Console.ReadLine());
		
		//Shows your name and what you have scored
		Console.WriteLine("Hello {0}", str1);
		Console.WriteLine("You scored {0}", dbl1);

		if(dbl1 < 40)
		{
			if (dbl1 > 0)
			{ 
				Console.WriteLine("This a FAIL score");
				//repeat code
				Main();
			}
		}
		if ((dbl1 >= 40) && (dbl1 <= 100))
		{
			Console.WriteLine("This is a PASS score");
			//repeat code
			Main();

			if (dbl1 >= 75)
				Console.WriteLine("You did very well!");
			//repeat code
			Main();
		}
		else
		{
			Console.WriteLine("Oh dear - you have put in a wrong test score");

			//repeat the code after wrong test score input
			Main();
		}
	}
	
}
