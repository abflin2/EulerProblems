using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EulerProblem5
{
	class Program
	{
		static void Main(string[] args)
		{
			bool divisible = false;
			int top = 20;
			int num = top -1; // I know that no number under top can be divisible by all numbers under top, so I'll start here.
			DateTime start = DateTime.Now;
			while (!divisible)
			{
				num++;
				
				for (int i = 2; i <= top; i+=2)
				{
					if (num % i != 0)
					{
						divisible = false;
						break;
					}

					else
						divisible = true;
				}
			}
			TimeSpan time = DateTime.Now - start ;
			Console.WriteLine("The smallest number divisible by all numbers from 1 to " + top + " is: " + num);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
