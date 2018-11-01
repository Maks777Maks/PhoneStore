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
using UI.Classes;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserUI _User;
        List<PhoneUI> phones = new List<PhoneUI>();
        PhoneUI selectedphone;


        public MainWindow(UserUI user)
        {
            InitializeComponent();
            
            phones.Add(new PhoneUI { Mark = "Xiaomy", Model = "Redmi Note 5", Price = 5800 });
            phones.Add(new PhoneUI { Mark = "Samsung", Model = "J7", Price = 3800 });
            phones.Add(new PhoneUI { Mark = "Huawey", Model = "P Smart+", Price = 9800 });
            ListView.ItemsSource = phones;
            _User = user;
            UserName.Text ="Name: "+_User.Name;
            UserMail.Text = "Mail: "+ _User.Mail;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedphone = (ListView.SelectedItems[0] as PhoneUI);
            Order o = new Order(selectedphone,_User);
            o.ShowDialog();
        }
    }
}
