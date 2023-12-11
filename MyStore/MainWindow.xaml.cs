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

namespace MyStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = passBox.Password.Trim();
            string password2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введено некорректно!";
                textBoxLogin.Background = Brushes.Red;
            }
            else if(password.Length < 5)
            {
                passBox.ToolTip = "Это поле введено некорректно!";
                passBox.Background = Brushes.Red;
            }
            else if (password != password2)
            {
                passBox2.ToolTip = "Это поле введено некорректно!";
                passBox2.Background = Brushes.Red;
            }
            else if (email.Length < 5 | !email.Contains("@") | !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено некорректно!";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Все в порядке");

                User user = new User(login, password, email);

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void Button_Window_Auth_Click(object sender, EventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
