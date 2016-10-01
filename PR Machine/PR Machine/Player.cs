using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_Machine
{
    class Player
    {
        public List<Placing> placings = new List<Placing>();
        private string name;
        private double totalScore;

        public Player(string Name)
        {
            name = Name;
            totalScore = 0;
        }

        public double TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddPlacing(Placing placing)
        {
            placings.Add(placing);
        }

        public void DisplayPlayer(Form1 form)
        {
            form.DisplayBox.AppendText("Player: " + name + "\nPlacement Info:\n");
            foreach(Placing p in placings)
            {
                form.DisplayBox.AppendText(p.displayPlacing());
            }
            form.DisplayBox.AppendText(Environment.NewLine);
        }

        public double getTotalScore()
        {
            totalScore = 0;

            foreach (Placing place in placings)
            {
                totalScore += place.PointValue;
            }

            return totalScore;
        }
    }
}
