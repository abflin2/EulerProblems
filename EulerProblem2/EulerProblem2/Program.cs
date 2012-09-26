using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 	Problem 2 - By considering the terms in the Fibonacci sequence whose values 
 * 	do not exceed four million, find the sum of the even-valued terms.
 */

namespace EulerProblem2
{
	class Program
	{
		static void Main(string[] args)
		{
			const int MAX = 4000000;
			long total = 0;

			int n = 0;
			int nm1 = 1;
			int nm2 = 0;


			do
			{
				n = nm1 + nm2;

				if (n % 2 == 0)
					total += n;

				nm2 = nm1;
				nm1 = n;
			} while (n < MAX);

			Console.WriteLine("The sum is " + total);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
