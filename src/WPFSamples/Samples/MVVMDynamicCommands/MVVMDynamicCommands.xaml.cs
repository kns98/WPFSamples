using System.ComponentModel;

namespace WPFSamples.Samples.MVVMDynamicCommands
{
    [Category("ItemsControl")]
    [Description("Demonstrates how an ItemsControl with Buttons can be bound to a collection of ICommands")]
    [RelatedUrl("http://stackoverflow.com/questions/29389191/mvvm-with-dynamic-commands", "MVVM with dynamic commands")]
    public partial class MVVMDynamicCommands
    {
        public MVVMDynamicCommands()
        {
            InitializeComponent();

            var vm = new ViewModel();
            vm.AddSomeCommands();

            this.DataContext = vm;
        }
    }
}
