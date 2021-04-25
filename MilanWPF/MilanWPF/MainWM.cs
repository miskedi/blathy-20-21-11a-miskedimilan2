using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MilanWPF
{

        public class MainVM : ViewModelBase
        {
            public MainVM()
            {
                this.PropertyChanged += MainVM_PropertyChanged;
                nameData = new ObservableCollection<Class>();
                Name = new ObservableCollection<string>();


                CMD_New = new RelayCommand(() => { Selected = new Class(); }, () => Selected is null || nameData.Contains(Selected));

                CMD_Add = new RelayCommand(() => { nameData.Add(Selected); Selected = null; }, () => !nameData.Contains(Selected) && SelectedNotNull);

                CMD_Clear = new RelayCommand(() => { nameData.Clear(); }, () => nameData.Count > 0);

                CMD_Remove = new RelayCommand(() => { nameData.Remove(Selected); }, () => SelectedNotNull && nameData.Contains(Selected));

            }

            private void MainVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {

                switch (e.PropertyName)
                {
                    case "Selected":
                        SelectedNotNull = Selected != null;
                        break;
                    default:
                        break;
                }
            }
            private bool selectedNotNull;
            private string input;
            private string output;
            private Class selected;
            public string Input { get => input; set => Set(ref input, value); }
            public string Output { get => output; set => Set(ref output, value); }
            public Class Selected { get => selected; set => Set(ref selected, value); }
            public bool SelectedNotNull { get => selectedNotNull; set => Set(ref selectedNotNull, value); }
            public ICommand CMD_Clear { get; set; }
            public ICommand CMD_Add { get; set; }
            public ICommand CMD_Remove { get; set; }
            public ICommand CMD_New { get; set; }
            private bool ClearCanExecute()
            {
                return nameData.Count > 0;
            }

            public ObservableCollection<string> Name { get; private set; }
            public ObservableCollection<Class> nameData { get; private set; }
        }
}
    

