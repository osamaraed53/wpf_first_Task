using System.Net.WebSockets;
using System.Windows;
using WpfFirstApp.View;
using WpfFirstApp.ViewModel;

namespace WpfFirstApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {

        InitializeComponent();
        MainWindowViewModel vw = new MainWindowViewModel();
        DataContext = vw;
    }

}







//DataContext = this;
//entries = new ObservableCollection<string>();

//public event PropertyChangedEventHandler? PropertyChanged;
//private ObservableCollection<string> entries;
//public ObservableCollection<string> Entries
//{
//    get { return entries; }
//    set { entries = value; }
//}
//private void btnAdd_Click(object sender, RoutedEventArgs e)
//{
//    Entries.Add(txtEntry.Text);
//}
//private void btnDelete_Click(object sender, RoutedEventArgs e)
//{
//}