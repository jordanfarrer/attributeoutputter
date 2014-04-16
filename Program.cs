using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentOutputter
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				for (var i = 0; i < args.Length; i++)
				{
					Console.WriteLine(string.Format("Argument {0}: {1}", i, args[i]));
				}


			}
			else
				Console.WriteLine("No arguments were passed.");

			System.Threading.Thread.Sleep(5000);
		}
	}
}
