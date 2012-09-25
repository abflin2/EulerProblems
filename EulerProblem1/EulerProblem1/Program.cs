using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblem1
{
	//Problem 1 - Add all the natural numbers below one thousand that are multiples of 3 or 5.
	class Program
	{
		static void Main(string[] args)
		{
			int max = 1000;
			int total = 0;

			for (int i = 1; i < max; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					total += i;
					Console.WriteLine(i + " is a multiple of either 3 or 5");
				}

			}

			Console.WriteLine();
			Console.WriteLine("The total is " + total);
			Console.WriteLine("Press any key to exit...");
			Console.ReadLine();
		}
	}
}
