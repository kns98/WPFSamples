using System.ComponentModel;
using System.Collections.ObjectModel;
using System;

namespace WPFSamples.Samples.ComputerList
{
    [Category("ItemsControl")]
    [Description("Shows different List views bound to the same data with different ItemTemplates, representing a list of connected PCs in a network.")]
    [RelatedUrl("http://stackoverflow.com/questions/15323577/how-to-add-a-table-grid-to-a-vb-net-c-wpf-window", "How to add a table/grid to a vb.net/C# WPF window?")]
    public partial class ComputerList : SampleWindow
    {
        private RandomConnectionAdder adder;
        private readonly ObservableCollection<Connection> Connections;

        public ComputerList()
        {
            InitializeComponent();

            Connections = new ObservableCollection<Connection>();
            adder = new RandomConnectionAdder(x => Dispatcher.BeginInvoke((Action)(() => AddConnection(x))));
            DataContext = Connections;
        }

        private void AddConnection(Connection connection)
        {
            Connections.Add(connection);
        }
    }
}
