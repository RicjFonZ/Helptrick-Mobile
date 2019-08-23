using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using HelptrickMobile.Infrastructure;

namespace HelptrickMobile.ViewModels
{
    public class MDChildViewModel : AppMapViewModelBase
    {


        public MDChildViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
