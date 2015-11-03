using System.Collections.Generic;
using System.ComponentModel;

namespace WPFSamples.Samples.ImprovingWinformsPerformance
{
    public class Item : INotifyPropertyChanged
    {
        private List<string> _values;
        public List<string> Values
        {
            get { return _values ?? (_values = new List<string>()); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Description { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Item()
        {
            Values.Add("Value1");
            Values.Add("Value2");
            Values.Add("Value3");
            Values.Add("Value4");
            Values.Add("Value5");
            Values.Add("Value6");
        }
    }
}