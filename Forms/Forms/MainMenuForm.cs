using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary;

namespace Forms
{
    public partial class MainMenuForm : Form
    {
        private static string log;
        Worker driver;
        Client client;
        Ride ride;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        public MainMenuForm(string data)
        {
            InitializeComponent();
            log = data;
            HelloText.Text = $"Hello, {log}";
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            if (AddressCurr.Text == "")
            {
                MessageBox.Show("Enter your current address");
                return;
            }
            else if(AddressToGo.Text == "")
            {
                MessageBox.Show("Enter where you want to go");
                return;
            }

            client = new Client(log);
            client.ReadFromDBase();
            ride = new Ride(client);
            ride.GetDistanceOfRide();
            ride.CountFare();

            FareLabel.Text = $"Fare: {ride.fare} grivnas";
            DistanceLabel.Text = $"Distance: {ride.distance}m";

            if(ride.isVip)
            {
                DiscountLabel.Text = "Discount: 5%";
            }
            else
            {
                DiscountLabel.Text = "Discount: No";
            }

            ride.CheckVip(client);

            driver = ride.GetDriver(driver);
            DriverLabel.Text = $"Driver: {driver.Name}, {driver.Age} years";

            CarLabel.Text = $"Car: {driver.CarModel} {driver.CarNumber}";

            EndButton.Enabled = true;
            RequestButton.Enabled = false;

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            client.AmountOfRides();
            driver.AmountOfRides();

            driver.CountSalary(ride.fare);
            AddressCurr.Text = "";
            AddressToGo.Text = "";

            FareLabel.Text = "Fare:";
            DistanceLabel.Text = "Distance:";
            DriverLabel.Text = "Driver:";
            CarLabel.Text = "Car:";
            DiscountLabel.Text = "Discount:";

            EndButton.Enabled = false;
            RequestButton.Enabled = true;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
        }
    }
}
