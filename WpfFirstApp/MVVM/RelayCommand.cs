using System.Windows.Input;

namespace WpfFirstApp.MVVM;

internal class RelayCommand : ICommand
{
    private Action<Object> execute;
    private Func<Object, bool> canExecute;

    public RelayCommand(Action<object> execute , Func<object,bool> canExecute = null )
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value;}    }
    public bool CanExecute(object? parameter)
    {
        return canExecute == null  || canExecute(parameter);
    }
    public void Execute(object? parameter)
    {
        execute(parameter);
    }
}
