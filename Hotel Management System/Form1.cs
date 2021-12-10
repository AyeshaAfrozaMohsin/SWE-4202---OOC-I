using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        List<SingleRoom> singleList = new List<SingleRoom>();
        List<DoubleRoom> doubleList = new List<DoubleRoom>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSingleRoom(object sender, EventArgs e)
        {
            SingleRoom dummy = new SingleRoom();
            dummy.Name = SingleRoomNameBox.Text;
            dummy.Quantity = Convert.ToInt32(SingleRoomQuantityBox.Text);
            dummy.AirConditioning= SingleRoomAirConditioningBox.Text;
            dummy.GameSetup = SingleRoomGameSetupBox.Text;
            if (SingleRoomRefrigeratorBox.Text != "")
            {
                dummy.Refrigerator = Convert.ToInt32(SingleRoomRefrigeratorBox.Text);
            }

            singleList.Add(dummy);
            MessageBox.Show("Single Room Added Succesfully.");

            ShowSingleRoomCostLabel.Text = Convert.ToString(dummy.CalculateCost());
        }

        private void AddDoubleRoom(object sender, EventArgs e)
        {
            DoubleRoom dummy = new DoubleRoom();
            dummy.Name = DoubleRoomNameBox.Text;
            dummy.Quantity = Convert.ToInt32(DoubleRoomQuantityBox.Text);
            dummy.Bed = Convert.ToInt32(DoubleRoomBedsBox.Text);
            dummy.AirConditioning = DoubleRoomAirConditioningBox.Text;
            dummy.Breakfast = DoubleRoomBreakfastBox.Text;
            if (DoubleRoomRefrigeratorBox.Text != "")
            {
                dummy.Refrigerator = Convert.ToInt32(DoubleRoomRefrigeratorBox.Text);
            }
            if (DoubleRoomTvBox.Text != "")
            {
                dummy.TV = Convert.ToInt32(DoubleRoomTvBox.Text);
            }

            doubleList.Add(dummy);
            MessageBox.Show("Double Room Added Succesfully.");

            ShowDoubleRoomCostLabel.Text = Convert.ToString(dummy.CalculateCost());
        }

        private void Rent(object sender, EventArgs e)
        {
            for ( int i =0; i< singleList.Count; i++ )
            {
                if (singleList[i].Name == RentingRoomNameBox.Text)
                {
                    if (singleList[i].Quantity - Convert.ToInt32(RentingQuantityBox.Text) > 0)
                        singleList[i].Quantity = singleList[i].Quantity - Convert.ToInt32(RentingQuantityBox.Text);
                    else
                    {
                        MessageBox.Show("Not Enough Rooms.");
                        goto There;
                    }
                
                    goto Here;
                }
            }

            for (int i = 0; i < doubleList.Count; i++)
            {
                if (doubleList[i].Name == RentingRoomNameBox.Text)
                {
                    if (doubleList[i].Quantity - Convert.ToInt32(RentingQuantityBox.Text) > 0)
                        doubleList[i].Quantity = doubleList[i].Quantity - Convert.ToInt32(RentingQuantityBox.Text);
                    else
                    {
                        MessageBox.Show("Not Enough Rooms.");
                        goto There;
                    }
                    goto Here;
                }
            }

            MessageBox.Show("Room Not Found.");
            goto There;

        Here:
            MessageBox.Show("Room rented Sucessfully");

        There:
            ;
        }

        private void Show(object sender, EventArgs e)
        {
            for (int i = 0; i < singleList.Count; i++)
            {
                if (singleList[i].Name == RentingRoomNameBox.Text)
                {
                    ShowQuantityAvailableLabel.Text = Convert.ToString(singleList[i].Quantity);
                    goto Here;
                }
            }

            for (int i = 0; i < doubleList.Count; i++)
            {
                if (doubleList[i].Name == RentingRoomNameBox.Text)
                {
                    ShowQuantityAvailableLabel.Text = Convert.ToString(doubleList[i].Quantity);
                    goto Here;
                }
            }

            MessageBox.Show("Room Not Found.");

            Here:

            ;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SingleRoomGameSetupBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SingleRoomQuantity_Click(object sender, EventArgs e)
        {

        }

        private void SingleRoomQuantityBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
