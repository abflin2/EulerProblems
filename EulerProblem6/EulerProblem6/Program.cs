using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblem6
{
	class Program
	{
		static void Main(string[] args)
		{
			int targetNum = 100;
			int difference = 0;
			int sum = sumOfSquares(targetNum);
			int square = squareOfSum(targetNum);
			

			if(sum > square) 
				difference = sum - square;
			else 
				difference = square - sum;

			Console.WriteLine("The difference between the sum of the squares and the square of the sums for " + targetNum + " is " + difference);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		static int sumOfSquares(int num)
		{
			int total = 0;
			for (int i = 1; i <= num; i++)
			{
				total += i * i;
			}

			return total;
		}

		static int squareOfSum(int num)
		{
			int total = 0;
			for (int i = 1; i <= num; i++)
			{
				total += i;
			}

			total *= total;
			return total;
		}

	}
}
