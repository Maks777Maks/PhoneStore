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
using System.Windows.Shapes;
using UI.Classes;

namespace UI
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public PhoneUI phone;
       
        OrderUI order;
        UserUI user;
        public Order(PhoneUI phone,UserUI user)
        {
            InitializeComponent();
            this.phone = phone;
            this.user = user;
            PhoneMark.Text = phone.Mark;
            PhoneModel.Text = phone.Model;
            PhonePrice.Text = phone.Price.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Confirm this order", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                order = new OrderUI { Phone = phone, dateTime = DateTime.Now,User=user};
                this.Close();
                
            }
            else
                this.Close();
        }
    }
}
