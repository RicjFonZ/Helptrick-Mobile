using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelptrickMobile.Views;
using HelptrickMobile.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelptrickMobile
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage/NavigationPage/MDChild");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MDChild, MDChildViewModel>();
            containerRegistry.RegisterForNavigation<MDChild1, MDChild1ViewModel>();
            containerRegistry.RegisterForNavigation<MDChild2, MDChild2ViewModel>();
        }
    }
}
