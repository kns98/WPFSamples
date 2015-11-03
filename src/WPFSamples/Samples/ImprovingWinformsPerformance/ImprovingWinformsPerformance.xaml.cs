using System.Collections.Generic;
using System.ComponentModel;

namespace WPFSamples.Samples.ImprovingWinformsPerformance
{
    [Category("Performance")]
    [Description("Large Datagrid-like UI made with nested ItemsControls\r\nOriginally it was a winforms problem but I proposed a WPF based solution showing how WPF's accelerated rendering and advanced Visual Tree and DependencyProperty system outperform winforms in scenarios where large amounts of UI elements are involved.")]
    [RelatedUrl("http://stackoverflow.com/questions/14565773/improving-winforms-performance-with-large-number-of-controls", "Improving Winforms performance with large number of controls")]
    public partial class ImprovingWinformsPerformance : SampleWindow
    {
        private List<Item> _items;
        public List<Item> Items
        {
            get { return _items ?? (_items = new List<Item>()); }
        }

        public ImprovingWinformsPerformance()
        {
            InitializeComponent();

            Items.Add(new Item() { Description = "Base metal Thickness" });

            for (var i = 32; i > 0; i--)
            {
                Items.Add(new Item() { Description = "Metal Specification " + i.ToString() });
            }

            Items.Add(new Item() { Description = "Base metal specification" });

            DataContext = this;
        }

    }
}
