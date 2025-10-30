    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;

namespace CalcuNotifyChanged_JDDLG
{
    [AddINotifyPropertyChangedInterface]
    internal class MainPageViewModel
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public ICommand SumaCommand => new Command(() =>
        {
            Result = Num1 + Num2;
        });
    }
}
