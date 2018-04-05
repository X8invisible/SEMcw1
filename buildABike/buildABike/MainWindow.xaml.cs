using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business;

namespace buildABike
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stocks instance = Stocks.Instance;
        private bool warranty = false;
        private double total = 0;
        private int days = 0;
        private int hours = 0;
        private List<Bike> bikes = new List<Bike>();
        public MainWindow()
        {
            InitializeComponent();
            dgridBikes.ItemsSource = bikes;
        }
         public void UpdatePrice()
        {
            total = 0;
            foreach(Bike b in bikes)
            {
                total += b.Price;
            }
            lblPrice.Content = "Total Price: £" + total.ToString();
        }
          public void UpdateDelivery()
        {
            days = 0; hours = 0;
            foreach(Bike b in bikes)
            {
                hours += b.Hours;
            }
            days = hours / 24;
            hours = hours % 24;
            lblDelivery.Content = "Delivery time: "+ days.ToString() +"d " + hours.ToString()+"hr";
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bike bike = new Bike(cboxFrameSize.SelectedIndex, cboxFrameColour.SelectedIndex, cboxGears.SelectedIndex,
                cboxBrakes.SelectedIndex, cboxWheels.SelectedIndex, cboxHandle.SelectedIndex, cboxSaddle.SelectedIndex, warranty);
                if(instance.UpdateStocks(cboxFrameSize.SelectedIndex, cboxGears.SelectedIndex, cboxBrakes.SelectedIndex, cboxWheels.SelectedIndex, cboxHandle.SelectedIndex, cboxSaddle.SelectedIndex))
                {
                    bikes.Add(bike);
                    dgridBikes.Items.Refresh();
                    UpdatePrice();
                    UpdateDelivery();
                }
                else
                {
                    MessageBox.Show("Not enough stock");
                }
                
            }
           catch(Exception ep)
            {
                MessageBox.Show(ep.Message, "Invalid Data", MessageBoxButton.OK);
            }
        }

        private void chkWarranty_Checked(object sender, RoutedEventArgs e)
        {
            warranty = true;
        }

        private void chkWarranty_Unchecked(object sender, RoutedEventArgs e)
        {
            warranty = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(dgridBikes.SelectedIndex != -1)
            {
                var bikeDel = dgridBikes.SelectedItem as Bike;
                instance.Revert(bikeDel.FrameSize, bikeDel.Gears, bikeDel.Brakes, bikeDel.Wheels, bikeDel.Handlebar, bikeDel.Saddle);
                bikes.Remove(bikeDel);
                dgridBikes.Items.Refresh();
                UpdatePrice();
                UpdateDelivery();
            }
            else
            {
                MessageBox.Show("Please select and item to delete", "No item selected", MessageBoxButton.OK);
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(bikes.Count > 0)
            {
                MessageBox.Show("Thank you for your order! Goodbye");
            }
        }
    }
}
