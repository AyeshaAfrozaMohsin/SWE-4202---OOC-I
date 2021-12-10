using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_Dependencies
{
    public class Car
    {
        String CarName;
        String Model;
        int NumberOfCars;

        public void SetCarName(String CarName)
        {
            this.CarName = CarName;
        }
        public void SetModel(String Model)
        {
            this.Model = Model;
        }
        public void SetNumberOfCars(int NumberOfCars)
        {
            this.NumberOfCars = NumberOfCars;
        }

        public String GetCarName()
        { return this.CarName; }
        public String GetModel()
        { return this.Model; }
        public int GetNumberOfCars()
        { return this.NumberOfCars; }

    }
}
