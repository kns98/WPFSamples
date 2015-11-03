using System.Windows;
using System.Diagnostics;
using System.ComponentModel;
using WPFSamples;

namespace MiscSamples
{
    [Category("Performance")]
    [Description("An optimized ControlTemplate for the Calendar control to improve rendering time")]
    [RelatedUrl("http://stackoverflow.com/questions/18540771/25-wpf-calendars-in-one-window-takes-5-seconds-to-open-window", "25 WPF Calendars in one window, takes 5 seconds to open Window")]
    public partial class CalendarSample
    {
        private Stopwatch sw;

        public CalendarSample()
        {
            sw = new Stopwatch();
            sw.Start();
            InitializeComponent();
            Loaded += new RoutedEventHandler(CalendarSample_Loaded);
        }

        void CalendarSample_Loaded(object sender, RoutedEventArgs e)
        {
            sw.Stop();
            Title = sw.Elapsed.ToString();
        }
    }
}
