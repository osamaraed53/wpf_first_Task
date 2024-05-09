using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfFirstApp.Model;
using WpfFirstApp.MVVM;

namespace WpfFirstApp.ViewModel;

internal class MainWindowViewModel : ViewModelBase
{

    public ObservableCollection<Item> Items { get; set; }

    public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
    public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
    public RelayCommand SaveCommand => new RelayCommand(execute => SaveItem(), canExecute => SelectedItem != null);

    private Item selectedItem;

    private Item newItem;

    public MainWindowViewModel()
    {
        Items = new ObservableCollection<Item>
        {
        new Item { Name = "Product1", SerialNumber = "001", Quantity = 5 },
        new Item { Name = "Product2", SerialNumber = "002", Quantity = 10 },
        new Item { Name = "Product3", SerialNumber = "003", Quantity = 10 },
        new Item { Name = "Product4", SerialNumber = "003", Quantity = 10 },
        };


    }


    public Item SelectedItem
    {
        get { return selectedItem; }
        set
        {
            selectedItem = value;
            OnPropertyChanged();
        }
    }

    public Item NewItem
    {
        get { return newItem; }
        set { newItem = value; }
    }


    private void SaveItem()
    {
        if (SelectedItem != null)
        {

        }
    }


    private void AddItem()
    {
        Items.Add(new Item
        {
            Name = newItem.Name,
            SerialNumber = newItem.SerialNumber,
            Quantity = newItem.Quantity
        });
    }
    private void DeleteItem()
    {
        Items.Remove(SelectedItem);
    }

}
