using System;
using System.Windows.Input;

namespace WPFSamples.Samples.MVVMDynamicCommands
{
    public class Command : ICommand
    {
        private readonly Action action;

        public string DisplayName { get; private set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action();
        }

        public Command(string displayName, Action action)
        {
            this.action = action;
            this.DisplayName = displayName;
        }
    }
}