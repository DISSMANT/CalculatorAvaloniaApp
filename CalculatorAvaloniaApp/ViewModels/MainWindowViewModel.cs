using System.Reflection.PortableExecutable;
using System.Windows.Input;
using ReactiveUI;

namespace CalculatorAvaloniaApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Increase = ReactiveCommand.Create<string>(IncreaseCommand);
        Operation = ReactiveCommand.Create<string>(OperationCommand);
        Equal = ReactiveCommand.Create(EqualCommand);
    }
    
    private string _value = "";
    public string Value
    {
        get => _value;
        private set => this.RaiseAndSetIfChanged(ref _value, value);
    }

    public ICommand Increase { get; }
    public ICommand Equal { get; }
    public ICommand Operation { get; }

    private void IncreaseCommand(string byValue)
    {
        Value += byValue;
    }

    private void EqualCommand()
    {
        
    }

    private void OperationCommand(string operation)
    {
        
    }
}