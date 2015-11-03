using System.ComponentModel;
using System.Collections.ObjectModel;

namespace WPFSamples.Samples.ListBoxAndUserControls
{
    [Category("ItemsControl")]
    [Description("A ListBox with several different types of items consisting of UserControls bound to different types of ViewModels.")]
    [RelatedUrl("http://stackoverflow.com/questions/14919415/binding-multiple-unique-usercontrols-in-a-listview-to-an-observablecollection", "Binding multiple unique UserControls in a ListView to an ObservableCollection")]
    public partial class ListBoxAndUserControls : SampleWindow
    {
        public ListBoxAndUserControls()
        {
            InitializeComponent();

            DataContext = new ObservableCollection<ItemBase>
                {
                    new Item1() {MyText1 = "This is MyText1 inside an Item1"},
                    new Item2() {MyText2 = "This is MyText2 inside an Item2"},
                    new Item3() {MyText3 = "This is MyText3 inside an Item3", MyBool = true}
                };
        }
    }
}
