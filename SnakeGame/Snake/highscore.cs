using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snake
{
    class highscore
    {
        public static int score { get; set; }

        public static void setHighscore(int input)
        {
            if (input > score)
                score = input;
        }

        public static void getScoreReport(int input)
        {
            string message;
            if (input > score)
                message = "You beat your high score!";
            else if (input == score)
                message = "You scored the same as your highscore!";
            else if (input < score)
                message = "You got lower than your highscore, try agian!";
            else
                message = "You cheated";

            MessageBox.Show(message);
            
        }
    }
}
