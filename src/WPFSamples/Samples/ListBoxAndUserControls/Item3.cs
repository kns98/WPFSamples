namespace WPFSamples.Samples.ListBoxAndUserControls
{
    public class Item3 : ItemBase
    {
        private string _myText3;
        public string MyText3
        {
            get { return _myText3; }
            set
            {
                _myText3 = value;
                NotifyPropertyChange("MyText3");
            }
        }

        private bool _myBool;
        public bool MyBool
        {
            get { return _myBool; }
            set
            {
                _myBool = value;
                NotifyPropertyChange("MyBool");
            }
        }
    }
}