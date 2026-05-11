using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForGit
{
	internal class Program
	{
		void Addition()
		{
			int a = 10, b = 20, c;
			c = a + b;
			Console.WriteLine($"Addition ={c}");
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			p.Addition();
		}
	}
}
