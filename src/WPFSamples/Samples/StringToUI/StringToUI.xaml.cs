using System.ComponentModel;
using System.Collections.Generic;

namespace WPFSamples.Samples.StringToUI
{
    [Category("Misc")]
    [Description("Shows how to use XamlReader.Parse() to create UI elements dynamically from a string containing XAML.")]
    [RelatedUrl("http://stackoverflow.com/questions/15693100/binding-a-control-to-xaml-provided-by-domain-object", "Binding a control to xaml provided by domain object")]
    public partial class StringToUI : SampleWindow
    {
        public List<Project> Projects { get; set; }

        public StringToUI()
        {
            InitializeComponent();
            Projects = new List<Project>
                           {
                               new Project()
                                   {
                                       DisplaySpecificationXml = 
                                        "<StackPanel>" + 
                                        "   <TextBlock FontWeight='Bold' Text='This is UserControl1'/>" + 
                                        "   <ComboBox Text='ComboBox'/>" + 
                                        "</StackPanel>"
                                   },
                               new Project()
                                   {
                                       DisplaySpecificationXml = 
                                        "<StackPanel>" + 
                                        "   <TextBlock FontWeight='Bold' Text='This is UserControl2'/>" + 
                                        "   <CheckBox Content='CheckBox'/>" + 
                                        "</StackPanel>"
                                   }
                           };
            DataContext = this;
        }

    }
}
