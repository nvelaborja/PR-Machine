using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_Machine
{
    class Placing
    {
        private int place;
        private double pointValue;
        private string tournamentName = "No Tournament Name Provided";
        private bool isMonthly; // False meaning weekly tournament

        public Placing(int Place, bool is_monthly)
        {
            place = Place;
            pointValue = PlaceToPoint(place);
            isMonthly = is_monthly;
        }

        public Placing(int Place, bool is_monthly, string TournamentName)
        {
            tournamentName = TournamentName;
            place = Place;
            isMonthly = is_monthly;
            pointValue = PlaceToPoint(place);
        }

        private double PlaceToPoint(int place)
        {
            double pointValue = 0.0;

            // TODO: Decide point values based on placing, currently just zero
            /* 1 = 1.0
             * 2 = 0.8
             * 3 = 0.7
             * 4 = 0.6
             * 5 = 0.5
             * 7 = 0.4
             * 9 = 0.3
             * 13 = 0.2
             * */

            switch(place)
            {
                case 1:
                    pointValue = 1.0;
                    break;
                case 2:
                    pointValue = 0.8;
                    break;
                case 3:
                    pointValue = 0.7;
                    break;
                case 4:
                    pointValue = 0.5;
                    break;
                case 5:
                    pointValue = 0.4;
                    break;
                case 7:
                    pointValue = 0.3;
                    break;
                case 9:
                    pointValue = 0.2;
                    break;
                case 13:
                    pointValue = 0.1;
                    break;
            }

            if (isMonthly)
            {
                pointValue *= 0.75;
            }
            else
            {
                pointValue *= 0.25;
            }

            return pointValue;
        }

        public int Place
        {
            get { return place; }
            set { place = value; }
        }

        public double PointValue
        {
            get { return pointValue; }
            set { pointValue = value; }
        }

        public string Tournament
        {
            get { return tournamentName; }
            set { tournamentName = value; }
        }

        public bool IsMonthly
        {
            get { return isMonthly; }
            set { isMonthly = value; }
        }

        public string displayPlacing()
        {
            string output = "";

            output = "Place " + place + " valued at " + pointValue + " points at '" + tournamentName + "'.\n";

            return output;
        }
    }

}
