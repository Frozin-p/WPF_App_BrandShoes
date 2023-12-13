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
    public partial class CartPageWindow : Window
    {
        public CartPageWindow()
        {
            InitializeComponent();
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
