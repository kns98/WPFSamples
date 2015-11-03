namespace WPFSamples.Samples.ListBoxAndUserControls
{
    public class Item1 : ItemBase
    {
        private string _myText1;
        public string MyText1
        {
            get { return _myText1; }
            set
            {
                _myText1 = value;
                NotifyPropertyChange("MyText1");
            }
        }
    }
}