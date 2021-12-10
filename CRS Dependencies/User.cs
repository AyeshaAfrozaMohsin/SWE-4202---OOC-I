using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_Dependencies
{
    public class User
    {
        String UserID;
        String UserName;
        String Address;
        String Destination;
        String RentedCarName;

        public void SetUserID(String UserID)
        {
            this.UserID = UserID;
        }

        public void SetUserName(String UserName)
        {
            this.UserName= UserName;
        }

        public void SetAddress( String Address)
        {
            this.Address = Address;
        }

        public void SetDestination( String Destination)
        {
            this.Destination = Destination;
        }

        public void SetRentedCarName( String RentedCarName)
        {
            this.RentedCarName = RentedCarName;
        }



        public String GetUserID()
        { return this.UserID; }
        public String GetUserName()
        { return this.UserName; }
        public String GetAddress()
        { return this.Address; }
        public String GetDestination()
        { return this.Destination; }
        public String GetRentedCarName()
        { return this.RentedCarName; }


    }
}
