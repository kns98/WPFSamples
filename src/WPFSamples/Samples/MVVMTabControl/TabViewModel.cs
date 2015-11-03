namespace WPFSamples.Samples.MVVMTabControl
{
    public class TabViewModel : NotifyPropertyChangedBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyPropertyChange(() => Title);
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                NotifyPropertyChange(() => IsEnabled);
            }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                NotifyPropertyChange(() => IsVisible);
            }
        }
    }
}