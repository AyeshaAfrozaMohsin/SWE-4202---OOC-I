using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class DoubleRoom : Room
    {
        public string Breakfast;

        public int CalculateCost()
        {
            int cost = 3500;
            if (AirConditioning == "Yes")
            {
                cost = cost + 500;
            }
            if (Breakfast == "Yes")
            {
                cost = cost + 500;
            }
            cost = (TV - 1) * 1000;
            
            return cost;
        }
    }
}
