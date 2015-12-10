using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[4];

            Console.WriteLine("Please enter your test scores in order:");
            for (int x = 0; x < scores.Length; ++x)
            {
                scores[x] = Convert.ToInt32(Console.ReadLine());
                if (scores[x] > 100 || scores[x] < 0)
                {
                    --x;
                    Console.WriteLine("Please enter a valid score");
                }
                

            }

            Console.WriteLine();

            if (scores[0] < scores[1] && scores[1] < scores[2] && scores[2] < scores[3])
            {

                Console.WriteLine("Congrats on making improvement!");
                Console.WriteLine("Your test scores:");
                foreach (int tests in scores)
                    Console.WriteLine(tests);


            }

            else if (scores[0] > scores[1] && scores[1] > scores[2] && scores[2] > scores[3])
            {

                Console.WriteLine("It appears you regressed");
                Console.WriteLine("Your test scores:");
                for (int x = 3; x >= 0; --x)
                    Console.WriteLine(scores[x]);


            }

            else
            {

                Console.WriteLine("It appears there was no consistent pattern");
                Console.WriteLine("Your test scores:");
                foreach (int tests in scores)
                    Console.WriteLine(tests);


            }
        }
    }
}
