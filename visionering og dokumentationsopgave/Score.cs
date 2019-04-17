using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visionering_og_dokumentationsopgave
{
    class Score
    {
        public double Points(double score, string difficulty)
        {
            double new_score = 00.00;

            switch (difficulty)
            {
                case "easy":
                    new_score = score + 1;
                    break;
                case "medium":
                    new_score = score + 3;
                    break;
                case "hard":
                    new_score = score + 5;
                    break;
            }

            return new_score;
        }

        public void Highscore(double score)
        {
            string[] prev_scores = System.IO.File.ReadAllLines(@"Scores.txt");
            string[] all_scores = new string[prev_scores.Length + 1];
            double highest_score = 0;
            int i = 0;

            while (i < prev_scores.Length)
            {
                all_scores[i] = prev_scores[i];

                if (Convert.ToInt32(all_scores[i]) > Convert.ToInt32(highest_score))
                {
                    highest_score = Convert.ToInt32(all_scores[i]);
                }
                i++;
            }

            all_scores[i] = score.ToString();

            if (score > highest_score)
            {
                highest_score = score;
                Console.WriteLine("Congrats, you have the newest highscore!!!");
            }

            System.IO.File.WriteAllLines(@"Scores.txt", all_scores);
        }


    }
}
