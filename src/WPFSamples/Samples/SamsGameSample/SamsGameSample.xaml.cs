using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WPFSamples.Samples.SamsGameSample
{
    [Category("Animation")]
    [Description("A Timer-based example that shows a Player and many Enemy objects moving in a play field.\r\nThis example demonstrates DataBinding-based positioning/movement of visuals on screen.")]
    [RelatedUrl("http://stackoverflow.com/questions/16002932/game-graphics-quality-dependent-fps-control", "Game Graphics - Quality Dependent FPS Control?")]
    public partial class SamsGameSample : SampleWindow
    {
        public MainViewModel ViewModel { get; set; }

        #region Constructor

        public SamsGameSample()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
            DataContext = ViewModel;

            Loaded += (x, e) => ViewModel.NewLevel(30);
        }
    
        #endregion

        #region Window Events

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var direction = MoveDirections.Up;

            switch (e.Key)
            {
                case Key.Up:
                    direction = MoveDirections.Up;
                    break;
                case Key.Down:
                    direction = MoveDirections.Down;
                    break;
                case Key.Left:
                    direction = MoveDirections.Left;
                    break;
                case Key.Right:
                    direction = MoveDirections.Right;
                    break;
            }

            ViewModel.ToggleDirection(direction, true);
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            var direction = MoveDirections.Up;

            switch (e.Key)
            {
                case Key.Up:
                    direction = MoveDirections.Up;
                    break;
                case Key.Down:
                    direction = MoveDirections.Down;
                    break;
                case Key.Left:
                    direction = MoveDirections.Left;
                    break;
                case Key.Right:
                    direction = MoveDirections.Right;
                    break;
            }

            ViewModel.ToggleDirection(direction, false);
        }

        #endregion

        #region Game Parameters

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            GameParameters.GameAreaHeight = GameArea.ActualHeight;
            GameParameters.GameAreaWidth = GameArea.ActualWidth;
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
