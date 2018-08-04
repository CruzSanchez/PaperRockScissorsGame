using System;

namespace PaperRockScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {

			var PlayerScore = 0;
			var CPUScore = 0;
			var GameRound = 0;
			

			Random rnd = new Random();
			int CPUChoice = rnd.Next(4);

			Console.WriteLine("Lets play Paper, rock, scissors!");


			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(CPUChoice);


				Console.ReadLine();



				Console.WriteLine(CPUChoice);
			}



			
			Console.ReadLine();





		}
    }
}
