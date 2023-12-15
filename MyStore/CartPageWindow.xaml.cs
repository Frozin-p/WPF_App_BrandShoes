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
using System.Windows.Shapes;

namespace MyStore
{
    /// <summary>
    /// Interaction logic for CartPageWindow.xaml
    /// </summary>
    /// 

    public partial class CartPageWindow : Window
    {
        ApplicationContext datb;

        public CartPageWindow()
        {
            InitializeComponent();

            datb = new ApplicationContext();

            List<Shoe> shoes = datb.Shoes.ToList();
            List<string> tb = new List<string>();
            foreach (Shoe shoe in shoes)
            {
                tb.Add($"{shoe.Brand} {shoe.Model} - {shoe.Price} руб.");
            }
            textBox_1.Text = tb[0];
            textBox_2.Text = tb[1];
            textBox_3.Text = tb[2];
            textBox_4.Text = tb[3];
            textBox_5.Text = tb[4];


            VansGrid.Visibility = Visibility.Collapsed;
            DunkGrid.Visibility = Visibility.Collapsed;
            SambaGrid.Visibility = Visibility.Collapsed;
            RSZGrid.Visibility = Visibility.Collapsed;
            OcaiGrid.Visibility = Visibility.Collapsed;

/*            HomePageWindow homePageWindow = new HomePageWindow();
            if (homePageWindow.VansButton.IsEnabled)
            {
                VansGrid.Visibility = Visibility.Visible;
            }
            if (homePageWindow.DunkButton.IsEnabled)
            {
                DunkGrid.Visibility = Visibility.Visible;
            }
            if (homePageWindow.SambaButton.IsEnabled)
            {
                SambaGrid.Visibility = Visibility.Visible;
            }
            if (homePageWindow.RSZButton.IsEnabled)
            {
                RSZGrid.Visibility = Visibility.Visible;
            }
            if (homePageWindow.OcaiButton.IsEnabled)
            {
                OcaiGrid.Visibility = Visibility.Visible;
            }*/
        }

        private void UserPage_Button(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }

        private void Cart_Button(object sender, RoutedEventArgs e)
        {
            CartPageWindow cartPageWindow = new CartPageWindow();
            cartPageWindow.Show();
            Hide();
        }

        private void Favourites_Button(object sender, RoutedEventArgs e)
        {
            FavouritesPageWindow favouritesPageWindow = new FavouritesPageWindow();
            favouritesPageWindow.Show();
            Hide();
        }

        private void Home_Page_Button(object sender, RoutedEventArgs e)
        {
            HomePageWindow homePageWindow = new HomePageWindow();
            homePageWindow.Show();
            Hide();
        }
    }
}
