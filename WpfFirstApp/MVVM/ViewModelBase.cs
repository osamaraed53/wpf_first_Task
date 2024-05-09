using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfFirstApp.MVVM;

internal class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
    {
        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName) );
    }

}




