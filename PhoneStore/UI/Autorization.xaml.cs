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
using UI.Classes;

namespace UI
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text != "" && UserMail.Text != "")
            {
                UserUI user = new UserUI { Name = UserName.Text, Mail = UserMail.Text };
                MainWindow mw = new MainWindow();
                mw.ShowDialog();
                this.Close();
            }
        }
    }
}
