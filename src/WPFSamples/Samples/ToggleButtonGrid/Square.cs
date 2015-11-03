using System.ComponentModel;

namespace WPFSamples.Samples.ToggleButtonGrid
{
    public class Square : INotifyPropertyChanged
    {
        private bool _state;
        public bool State
        {
            get { return _state; }
            set
            {
                _state = value;
                NotifyPropertyChanged("State");
            }
        }

        private Command _toggleCommand;
        public Command ToggleCommand
        {
            get { return _toggleCommand ?? (_toggleCommand = new Command(() => State = !State)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}