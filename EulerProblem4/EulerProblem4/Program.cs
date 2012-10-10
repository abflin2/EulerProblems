using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblem4
{
	class Program
	{
		static void Main(string[] args)
		{
			int rhs = 999;
			int lhs = 999;
			bool check = false;
			int pal = 0;
			int n = 0;

			while (lhs > 0)
			{
				for (int i = rhs; i > 0; i--)
				{
					n = i * lhs;
					check = isPalendrome(n);
					if (check && (n > pal))
						pal = n;
				}

				lhs--;
			}
			Console.WriteLine("Pal = " + pal);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		static bool isPalendrome(int num)
		{
			int n = num;
			int rev = 0;
			int dig; 

			while (num > 0)
			{
				dig = num % 10;
				rev = rev * 10 + dig;
				num = num / 10;
			}

			return n == rev;
		}
	}
}
