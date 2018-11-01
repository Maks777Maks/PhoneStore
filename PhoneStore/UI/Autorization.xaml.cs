using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UI.Classes;

namespace UI
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        UserUI user;

        string pattern = @"[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text != "" && UserMail.Text != ""&& Regex.IsMatch(UserMail.Text, pattern))
            {
                user = new UserUI { Name = UserName.Text, Mail = UserMail.Text};
                if (user != null)
                {
                    MainWindow mw = new MainWindow(user);
                    this.Close();
                    mw._User = user;
                    mw.ShowDialog();
                   
                }

            }
            else
            {
                MessageBox.Show("No correct Mail!!!");
                return;
            }
        }
    }
}
