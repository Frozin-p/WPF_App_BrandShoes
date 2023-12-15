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

namespace MyStore.Карточки_товаров
{
    /// <summary>
    /// Interaction logic for VansPageWindow.xaml
    /// </summary>
    public partial class VansPageWindow : Window
    {
        public VansPageWindow()
        {
            ApplicationContext datb;

            InitializeComponent();

            datb = new ApplicationContext();

            List<Shoe> shoes = datb.Shoes.ToList();
            List<string> tb = new List<string>();
            foreach (Shoe shoe in shoes)
            {
                tb.Add($"{shoe.Brand} {shoe.Model} \n {shoe.Price} руб.");
            }
            InfoAboutShoe.Text = tb[0];

        }

        private void BackToHome(object sender, RoutedEventArgs e)
        {
            HomePageWindow homePageWindow = new HomePageWindow();
            homePageWindow.Show();
            Hide();
        }
    }
}
