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

        private string player;
        private string club;
        private string position;

        public string FirstName { get => player; set => Set(ref player, value); }
        public string LastName { get => club; set => Set(ref club, value); }
        public string Alias { get => position; set => Set(ref position, value); }


    }
}
