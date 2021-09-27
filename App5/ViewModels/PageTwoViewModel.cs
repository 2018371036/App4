using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5.ViewModels
{
    public class PageTwoViewModel : BaseViewModel
    {
        Command _goToRoot;
        public PageTwoViewModel(INavigation navigation) : base(navigation)
        {
        }

        public Command GoToRootCommand { get => _goToRoot?? (_goToRoot = new Command(GoToRootAction));  }

        private void GoToRootAction()
        {
            Navigation.PopToRootAsync();
        }
    }
}
