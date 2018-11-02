using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
   public class UserUI : INotifyPropertyChanged
    {
        private int id;

        public event PropertyChangedEventHandler PropertyChanged;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                
                //System.Windows.MessageBox.Show($"You change value from {id} to {value}");
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
            }
        }

        public string Name { get; set; }
        public string Mail { get; set; }
        public List<OrderUI> orders { get; set; }
    }
}
