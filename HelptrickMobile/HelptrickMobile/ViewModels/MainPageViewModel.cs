using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using HelptrickMobile.Infrastructure;

namespace HelptrickMobile.ViewModels
{
    public class MainPageViewModel : AppMapViewModelBase
    {


        public MainPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
