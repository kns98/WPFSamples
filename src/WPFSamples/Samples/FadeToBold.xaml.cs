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

namespace WPFSamples.Samples
{
    [Category("Animation")]
    [Description("Opacity-based transition from normal to bold Text")]
    [RelatedUrl("http://stackoverflow.com/questions/13145702/possible-to-pulse-text-by-smoothly-changing-fontweight-in-wpf/13145941#13145941", "possible to pulse text by smoothly changing fontweight in WPF?")]
    public partial class FadeToBold : SampleWindow
    {
        public FadeToBold()
        {
            InitializeComponent();
        }
    }
}
