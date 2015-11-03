using System.Collections.ObjectModel;

namespace WPFSamples.Samples.ListBoxAndUserControls
{
    public class Item2 : ItemBase
    {
        private string _myText2;
        public string MyText2
        {
            get { return _myText2; }
            set
            {
                _myText2 = value;
                NotifyPropertyChange("MyText2");
            }
        }

        private ObservableCollection<string> _options;
        public ObservableCollection<string> Options
        {
            get { return _options ?? (_options = new ObservableCollection<string>()); }
        }

        public Item2()
        {
            Options.Add("Option1");
            Options.Add("Option2");
            Options.Add("Option3");
            Options.Add("Option4");
        }
    }
}