using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonercik
{
    public class RndNumberGuess
    {
        private int rndNumber, guessNumber;
        private Random random = new Random();
        private int guessCount = 3;

        public void Run()
        {
            StartGame();
        }

        private void StartGame()
        {
            rndNumber = random.Next(1, 11);
            Console.WriteLine("Aklimdaki sayiyi tahmin et!");

            for (int i = 0; i < guessCount; i++)
            {
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber == rndNumber)
                {
                    Console.WriteLine("Tebrikler! ");
                    CheckAnswer();
                }
                else if (guessNumber > (rndNumber + 2) || guessNumber < rndNumber - 2)
                {
                    Console.WriteLine("Soguk");
                }
                else
                {
                    Console.WriteLine("Sicak");
                }
            }

            Console.Write("Mal Adam! ");
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            Console.WriteLine("Tekrar oynamak ister misiniz?");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                StartGame();
            }
            else if (answer.ToUpper() == "N")
            {
                Environment.Exit(0);
            }
            else
            {
                CheckAnswer();
            }
        }
    }
}
