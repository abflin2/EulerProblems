using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
	public class Prime
	{
		public Prime(){ }

		//Code taken and altered from http://www.dotnetperls.com/prime
		public bool isPrime(long candidate)
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

		public long findNextPrime(long fromHere)
		{
			long prime = 0;
			bool primeFound = false;

			if (isPrime(fromHere))
			{
				prime = fromHere;
			}

			else
			{
				while (!primeFound)
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
	}
}
