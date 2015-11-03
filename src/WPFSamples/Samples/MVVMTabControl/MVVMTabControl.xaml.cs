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

namespace WPFSamples.Samples.MVVMTabControl
{
    [Category("ItemsControl")]
    [Description("An MVVM compliant TabControl bound to an ObservableCollection of ViewModels, with support for IsEnabled, Visibility and Tab header text.")]
    [RelatedUrl("http://stackoverflow.com/questions/15205626/handling-wpf-tabitems-visibility-property", "Handling WPF TabItems Visibility property")]
    public partial class MVVMTabControl : SampleWindow
    {
        public MVVMTabControl()
        {
            InitializeComponent();

            DataContext = new TabbedViewModel()
            {
                Items =
                {
                    new TabViewModel() {Title = "Tab #1", IsEnabled = true, IsVisible = true},
                    new TabViewModel() {Title = "Tab #2", IsEnabled = false, IsVisible = true},
                    new TabViewModel() {Title = "Tab #3", IsEnabled = true, IsVisible = false},
                }
            };
        }
    }
}
