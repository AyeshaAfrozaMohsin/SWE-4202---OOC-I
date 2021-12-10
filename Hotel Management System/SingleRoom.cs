using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class SingleRoom : Room
    {
        public string GameSetup;

        public int CalculateCost()
        {
            int cost=2000;
            if(AirConditioning == "Yes")
            {
                cost = cost + 500;
            }
            if(GameSetup == "Yes")
            {
                cost = cost + 1000;
            }

            return cost;
        }
    }
}
