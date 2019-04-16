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


    }
}
