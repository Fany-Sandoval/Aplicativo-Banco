using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Models
{
    public class Usuario : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private string email;
        public string telefono;

        public string UserName
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {

            get => password; set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {

            get => email; set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public string Telefono
        {

            get => telefono; set
            {
                telefono = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


    }
}
