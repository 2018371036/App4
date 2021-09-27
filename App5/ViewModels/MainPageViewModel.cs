using App5.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        Command _goToViewTwoCommand;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }
        public Command GoToViewTwoCommand
        {
            get => _goToViewTwoCommand ?? (_goToViewTwoCommand = new Command(GoToViewTwoAction));
        }

        private void GoToViewTwoAction()
        {
            Navigation.PushAsync(new NavigationPage(new PageTwo()));
        }
    }
}
