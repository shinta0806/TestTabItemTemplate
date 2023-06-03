using Microsoft.UI.Xaml.Controls;

using TestTabItemTemplate.ViewModels;

namespace TestTabItemTemplate.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
