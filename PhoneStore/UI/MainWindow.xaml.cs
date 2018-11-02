using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UI.ServiceReference2;
using UI.Util;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserUI _User { get; set; }
        ObservableCollection<PhoneUI> phones = new ObservableCollection<PhoneUI>();
        PhoneUI selectedphone;
        ServiceReference2.ContractClient client = new ContractClient();
        bool flag = false;


        public MainWindow(UserUI user)
        {
           
            
            InitializeComponent();
            _User = new UserUI();
            _User.ID = 10;

            foreach (var item in client.GetPhones())
            {
                var p = new PhoneUI { ID = item.ID, Mark = item.Mark, Model = item.Model, Price = item.Price };
                phones.Add(p);
            }
            ListView.ItemsSource = phones;




            foreach (var i in client.GetUsers())
            {

                if (i.Name == user.Name && i.Mail == user.Mail)
                {

                    _User = Mapper.UserFromDTO(i);
                    flag = true;

                    break;
                }
            }
            if (flag == false)
            {

                _User = user;
                client.AddUser(Mapper.UserFromUI(_User));
            }

            UserName.Text = _User.Name;
            UserMail.Text = _User.Mail;
            this.DataContext = _User;

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
            Order o = new Order(selectedphone, _User);
            o.ShowDialog();

        }
    }
}
