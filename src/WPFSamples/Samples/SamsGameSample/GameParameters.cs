using System;
using System.Windows;

namespace WPFSamples.Samples.SamsGameSample
{
    public abstract class GameObject : PropertyChangedBase
    {
        public static Random random = new Random();

        public Size Size { get; set; }

        public double MovementSpeed { get; set; }

        private Point _location;
        public Point Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged("Location");
            }
        }

        public Point AdjustToGameArea(Point point)
        {
            double X;
            double Y;

            if (point.X < 0)
                X = 0;
            else if (point.X > GameParameters.GameAreaWidth - Size.Width)
                X = GameParameters.GameAreaWidth - Size.Width;
            else
                X = point.X;

            if (point.Y < 0)
                Y = 0;
            else if (point.Y > GameParameters.GameAreaHeight - Size.Height)
                Y = GameParameters.GameAreaHeight - Size.Height;
            else
                Y = point.Y;

            return new Point(X, Y);
        }
    }

    public static class GameParameters
    {
        public static Double GameAreaHeight { get; set; }

        public static Double GameAreaWidth { get; set; }
    }
}