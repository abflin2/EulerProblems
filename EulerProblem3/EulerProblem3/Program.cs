using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblem3
{
	class Program
	{
		static void Main(string[] args)
		{
			const long compNum = 600851475143;
			long num = compNum;

			long prime = 0;
			long primeCand = 1;


			while (num > 1  && prime < compNum)
			{
				primeCand = findNextPrime(++primeCand);

				if (num % primeCand == 0)
				{
					prime = primeCand;
					num = removePrime(prime, num);
				}
			}

			Console.WriteLine("Largest prime is for " + compNum + " is: " + prime);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static long removePrime(long prime, long num)
		{
			if(num % prime != 0) 
				return num;

			num /= prime;

			return removePrime(prime, num);
		}

		static long findNextPrime(long fromHere)
		{
			long prime = 0;
			bool primeFound = false;

			if (isPrime(fromHere))
			{
				prime = fromHere;
			}

			else
			{
				while(!primeFound)
				{
					if (isPrime(++fromHere))
					{
						prime = fromHere;
						primeFound = true;
					}
				}	
			}

			return prime;
		}

		//Code taken and altered from http://www.dotnetperls.com/prime
		static bool isPrime(long candidate)
		{

			if ((candidate & 1) == 0)
			{
				if (candidate == 2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			for (long i = 3; (i * i) <= candidate; i += 2)
			{
				if ((candidate % i) == 0)
				{
					return false;
				}
			}
			return candidate != 1;
		}
	}

	
}
