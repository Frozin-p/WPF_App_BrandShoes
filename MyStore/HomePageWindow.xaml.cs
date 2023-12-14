using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for HomePageWindow.xaml
    /// </summary>
    /// 
    public partial class HomePageWindow : Window
    {

        ApplicationContext datb;
        public HomePageWindow()
        {
            InitializeComponent();

            datb= new ApplicationContext();

            List<Shoe> shoes = datb.Shoes.ToList();
            List<string> tb = new List<string>();
            foreach(Shoe shoe in shoes)
            {
                tb.Add($"{shoe.Brand} {shoe.Model} - {shoe.Price} руб.");
            }
            textBox_1.Text = tb[0];
            textBox_2.Text = tb[1];
            textBox_3.Text = tb[2];
            textBox_4.Text = tb[3];
            textBox_5.Text = tb[4];
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
            Hide();
            favouritesPageWindow.Show();
        }

        private void Home_Page_Button(object sender, RoutedEventArgs e)
        {
            HomePageWindow homePageWindow = new HomePageWindow();
            homePageWindow.Show();
            Hide();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text.ToLower() == "ni" || tb.Text.ToLower() == "nik" || tb.Text.ToLower() == "nike")
            {
                DunkGrid.Visibility= Visibility.Visible;

                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
                OcaiGrid.Visibility = Visibility.Collapsed;
                VansGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "n")
            {
                DunkGrid.Visibility = Visibility.Visible;
                VansGrid.Visibility = Visibility.Visible;

                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
                OcaiGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "oc" || tb.Text.ToLower() == "oca" || tb.Text.ToLower() == "ocai")
            {
                OcaiGrid.Visibility = Visibility.Visible;

                VansGrid.Visibility = Visibility.Collapsed;
                DunkGrid.Visibility = Visibility.Collapsed;
                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "o")
            {
                OcaiGrid.Visibility = Visibility.Visible;
                VansGrid.Visibility = Visibility.Visible;

                DunkGrid.Visibility = Visibility.Collapsed;
                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "v" || tb.Text.ToLower() == "va" || tb.Text.ToLower() == "van" || tb.Text.ToLower() == "vans")
            {
                VansGrid.Visibility = Visibility.Visible;

                DunkGrid.Visibility = Visibility.Collapsed;
                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
                OcaiGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "ad" || tb.Text.ToLower() == "adi" || tb.Text.ToLower() == "adid")
            {
                SambaGrid.Visibility = Visibility.Visible;

                RSZGrid.Visibility = Visibility.Collapsed;
                OcaiGrid.Visibility = Visibility.Collapsed;
                VansGrid.Visibility = Visibility.Collapsed;
                DunkGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "a")
            {
                SambaGrid.Visibility = Visibility.Visible;
                RSZGrid.Visibility = Visibility.Visible;
                OcaiGrid.Visibility = Visibility.Visible;
                VansGrid.Visibility = Visibility.Visible;

                DunkGrid.Visibility = Visibility.Collapsed;
            }
            else if (tb.Text.ToLower() == "p" || tb.Text.ToLower() == "pu" || tb.Text.ToLower() == "pum" || tb.Text.ToLower() == "puma")
            {
                RSZGrid.Visibility = Visibility.Visible;

                OcaiGrid.Visibility = Visibility.Collapsed;
                VansGrid.Visibility = Visibility.Collapsed;
                DunkGrid.Visibility = Visibility.Collapsed;
                SambaGrid.Visibility = Visibility.Collapsed;
            }
            else if( tb.Text == "")
            {
                VansGrid.Visibility = Visibility.Visible;
                DunkGrid.Visibility = Visibility.Visible;
                SambaGrid.Visibility = Visibility.Visible;
                RSZGrid.Visibility = Visibility.Visible;
                OcaiGrid.Visibility = Visibility.Visible;
            }
            else
            {
                VansGrid.Visibility = Visibility.Collapsed;
                DunkGrid.Visibility = Visibility.Collapsed;
                SambaGrid.Visibility = Visibility.Collapsed;
                RSZGrid.Visibility = Visibility.Collapsed;
                OcaiGrid.Visibility = Visibility.Collapsed;
            }
        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {

        }
    }
}
