using SimpleTrader.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
            public INavigator Navigator { get; set; } = new Navigator();
    }
}
