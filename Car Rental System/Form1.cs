using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Dependencies;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();
        int UserCount = 0;
        int CarCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveUserInfo(object sender, EventArgs e)
        {
            User dummy = new User();
            dummy.SetUserID(UserIDBox.Text);
            dummy.SetUserName(UserNameBox.Text);
            dummy.SetAddress(AddressBox.Text);
            dummy.SetDestination(DestinationBox.Text);

            users.Add(dummy);
            UserCount++;

            MessageBox.Show("User Saved Successfully.");
        }

        private void SaveCarInfo(object sender, EventArgs e)
        {
            Car dummy = new Car();
            dummy.SetCarName(CarNameBox.Text);
            dummy.SetModel(CarNameBox.Text);
            dummy.SetNumberOfCars(Convert.ToInt32(NumberOfCarsBox.Text));

            cars.Add(dummy);
            CarCount++;

            MessageBox.Show("Car Saved Sucessfully.");
        }

        private void RentCar(object sender, EventArgs e)
        {
            for( int i=0; i<users.Count; i++)
            {
                if ( users[i].GetUserID() == UserIDRentBox.Text )
                {
                    users[i].SetRentedCarName(CarNameRentBox.Text);
                    break;
                }
            }
            for( int i=0; i<CarCount ; i++)
            {
                if(cars[i].GetCarName() == CarNameRentBox.Text )
                {
                    cars[i].SetNumberOfCars(cars[i].GetNumberOfCars() - 1);
                    break;
                }
            }
            MessageBox.Show("Rented Sucessfully.");
        }

        private void ShowUserHistory(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetUserID() == UserIDRentBox.Text)
                {
                    ShowUserName.Text = users[i].GetUserName();
                    ShowAddress.Text = users[i].GetAddress();
                    ShowDestination.Text = users[i].GetDestination();
                    break;
                }
            }
            
        }

        private void ShowCarHistory(object sender, EventArgs e)
        {
            for(int i=0; i<cars.Count ; i++)
            {
                if( cars[i].GetCarName()== CarNameShowBox.Text )
                {
                    ShowCarModel.Text = cars[i].GetModel();
                    ShowNumberOfCars.Text= Convert.ToString(cars[i].GetNumberOfCars());
                    break;
                }
            }
        }
    }
}
