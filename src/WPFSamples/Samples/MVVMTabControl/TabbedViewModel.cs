using System.Collections.ObjectModel;

namespace WPFSamples.Samples.MVVMTabControl
{
    public class TabbedViewModel : NotifyPropertyChangedBase
    {
        private ObservableCollection<TabViewModel> _items;
        public ObservableCollection<TabViewModel> Items
        {
            get { return _items ?? (_items = new ObservableCollection<TabViewModel>()); }
        }

        private NotifyPropertyChangedBase _selectedItem;
        public NotifyPropertyChangedBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                NotifyPropertyChange(() => SelectedItem);
            }
        }
    }
}