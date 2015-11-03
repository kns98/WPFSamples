using System.ComponentModel;

namespace WPFSamples.Samples.TimerGauge
{
    [Category("Animation")]
    [Description("A gauge-like control that rotates based on an Angle property in a ViewModel, which is updated by a Timer.\r\nOriginally it was a winforms problem but I proposed a WPF based solution.")]
    [RelatedUrl("http://stackoverflow.com/questions/14710117/updating-ui-in-c-sharp-using-timer", "Updating UI in C# using Timer")]
    public partial class TimerGauge : SampleWindow
    {
        public TimerGauge()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

    }
}
