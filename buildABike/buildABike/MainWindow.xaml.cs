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
        private bool warranty = false;
        private double total = 0;
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
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bike bike = new Bike(cboxFrameSize.SelectedIndex, cboxFrameColour.SelectedIndex, cboxGears.SelectedIndex,
               cboxBrakes.SelectedIndex, cboxWheels.SelectedIndex, cboxHandle.SelectedIndex, cboxSaddle.SelectedIndex, warranty);
                bikes.Add(bike);
                dgridBikes.Items.Refresh();
                UpdatePrice();
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
    }
}
