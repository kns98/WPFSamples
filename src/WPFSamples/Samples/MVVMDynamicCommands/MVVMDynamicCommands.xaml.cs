using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
