using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionsExercises
{
	public class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";

			string email = "";

			do
			{
				Console.WriteLine("enter a valid email address:");
				email = Console.ReadLine();
			}

			//while (!Regex.IsMatch(email, pattern));
			while (!new Better().IsValid(email));

			Console.WriteLine($"Thanks! {email} is valid");
			Console.ReadKey();
		}
	}
}
