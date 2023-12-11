using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigbutt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int buttSize;

			Console.WriteLine("How big is your butt?");
			buttSize = int.Parse(Console.ReadLine());

			if (buttSize <= 2)
			{
				Console.WriteLine("Your butt is small im not gonna smack it");
			}
			else if (buttSize == 3)
			{
				Console.WriteLine("Your butt is decently sized, if im super horny ill smack it and maybe lick it");

			}
			else if (buttSize == 4) 
			{
				Console.WriteLine("Your butt is pretty big there, Why don't you come down and ill show it a good time!");
			}
			else if (buttSize >= 5)
			{
				Console.WriteLine("WOW Your butt is pretty big! you better pull your pants down RIGHT NOW so i can lick it clean");

			}
			else
			{
				Console.WriteLine("your butt couldnt possibly be that size...");
			}

			Console.ReadLine();
		}
	}
}
