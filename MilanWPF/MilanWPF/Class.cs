using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilanWPF
{
    public class Class : ObservableObject
    {
        public Class()
        {

        }

        private string firstName;
        private string lastName;
        private string alias;

        public string FirstName { get => firstName; set => Set(ref firstName, value); }
        public string LastName { get => lastName; set => Set(ref lastName, value); }
        public string Alias { get => alias; set => Set(ref alias, value); }


    }
}
