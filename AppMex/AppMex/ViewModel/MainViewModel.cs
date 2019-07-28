using AppMex.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMex.MainViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

    }
}
