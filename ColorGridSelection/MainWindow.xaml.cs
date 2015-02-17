using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ColorGridSelection
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CreateData();
        }

        private async void CreateData()
        {
            var brushes = await Task.Run(() => typeof(Brushes).GetProperties(BindingFlags.Static | BindingFlags.Public)
                                                              .Select(x => x.GetValue(null,null))
                                                              .OfType<Brush>()
                                                              .ToList());

            var random = new Random();

            var data = await Task.Run(() => Enumerable.Range(0, 32*32)
                                                      .Select(x => new
                                                      {
                                                          Text = "Text" + x,
                                                          Color = brushes[random.Next(0, brushes.Count - 1)]
                                                      })
                                                      .ToList());

            this.DataContext = data;
        }
    }
}
