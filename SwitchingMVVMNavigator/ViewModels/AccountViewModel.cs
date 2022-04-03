using SwitchingMVVMNavigator.Commands;
using SwitchingMVVMNavigator.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwitchingMVVMNavigator.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my account page.";
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }

    }
}
