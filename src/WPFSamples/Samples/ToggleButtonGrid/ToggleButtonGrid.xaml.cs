using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace WPFSamples.Samples.ToggleButtonGrid
{
    [Category("ItemsControl")]
    [Description("An ItemsControl showing a 6 x 8 Grid where cells change their State when clicked")]
    [RelatedUrl("http://stackoverflow.com/questions/15231456/is-it-possible-to-use-a-table-in-windows-forms-as-a-matrix", "Is it possible to use a table in Windows Forms as a matrix?")]
    public partial class ToggleButtonGrid : SampleWindow
    {
        public ToggleButtonGrid()
        {
            InitializeComponent();

            var rnd = new Random();
            DataContext = Enumerable.Range(0, 48).Select(x => new Square() {State = rnd.Next(0,5) > 3});
        }
    }
}
