using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication30
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                this.DataContext = Enumerable.Range(0,200)
                                             .Select(x => new Game())
                                             .ToList();
            };
        }
    }

    public class Game
    {
        public List<Square> Squares { get; private set; }
        private Timer timer;
        private Random random = new Random();

        public Game()
        {
            this.Squares = Enumerable.Range(0, 9).Select(x => new Square {Value = SquareValue.Empty}).ToList();
            this.timer = new Timer(Callback, null, TimeSpan.FromSeconds(3), TimeSpan.FromMilliseconds(10));
        }

        private void Callback(object state)
        {
            var sq = Squares[random.Next(0, 9)];
            var value = random.Next(0, 3);
            sq.Value = (SquareValue) value;
        }
    }

    public class Square: INotifyPropertyChanged
    {
        private SquareValue _value;
        public SquareValue Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum SquareValue
    {
        Empty = 0,
        X = 1,
        O = 2
    }
}
