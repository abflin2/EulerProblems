using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Prime;

namespace EulerProblem7
{

	//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

	//What is the 10 001st prime number?

	class Program
	{
		static void Main(string[] args)
		{
			const int PRIMECOUNT = 10001;
			//int numberFound = 0;
			long current = 1;
			Prime p = new Prime();

			for (int i = 1; i <= PRIMECOUNT; i++)
			{
				current++;
				if(!p.isPrime(current))
				{
					current = p.findNextPrime(current);
				}

				
					
			}

			Console.WriteLine("The " + PRIMECOUNT + "th prime number is " + current);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
