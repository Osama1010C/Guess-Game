using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Game
{
    class Hint
    {
        private int number;
        private static List<string> hintsList;

        private int Number => this.number;

        public Hint(int number)
        {
            this.number = number;
            hintsList = new List<string>();
        }
        public Hint() : this(0)
        {

        }

        public void CreateHints()
        {
            if (Number % 2 == 0) hintsList.Add("The Number Is Even");
            if (Number % 2 != 0) hintsList.Add("The Number Is Odd");
            if (Number % 4 == 0) hintsList.Add("The Number Is Divisible by 4");
            if (Number % 5 == 0) hintsList.Add("The Number Is Divisible by 5");
            int range1 = Number - 10 < 0 ? 0 : Number - 10;
            int range2 = Number + 10;
            hintsList.Add($"The Number Is Between {range1} And {range2}");
            if (Number > 10) { hintsList.Add("Number Is Greater Than 10"); hintsList.Add("Number consist of 2 digits"); }
            if (Number < 10) { hintsList.Add("Number Is Less Than 10"); hintsList.Add("Number consist of 1 digit"); }
            if (Number > 25) hintsList.Add("Number Is Greater Than 25");
            if (Number < 25) hintsList.Add("Number Is Less Than 25");
            if (Number == 7) hintsList.Add("The Best Player In The World");
            if (Number == 10) hintsList.Add("The Second Best Player In The World");
            if (Number > 30) hintsList.Add("Number Is Greater Than 30");
            if (Number < 30) hintsList.Add("Number Is Less Than 30");
        }

        public string GetHint()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, hintsList.Count());
            string theHint = hintsList[randomNumber];
            hintsList.RemoveAt(randomNumber);
            return theHint;
        }

        private int NumberOfHints() => hintsList.Count();
    }
}
