using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestTabItemTemplate.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
        TabItems.Add(1);
        TabItems.Add(2);
    }

    public ObservableCollection<Int32> TabItems
    {
        get;
        set;
    } = new();
}
