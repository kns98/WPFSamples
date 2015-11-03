using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace WPFSamples.Samples.SamsGameSample
{
    public class MainViewModel: PropertyChangedBase
    {
        #region Score and Lives

        private int _score;
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged("Score");
            }
        }

        private int _lives;
        public int Lives
        {
            get { return _lives; }
            set
            {
                _lives = value;
                OnPropertyChanged("Lives");
            }
        }

        #endregion

        #region Game Objects

        private ObservableCollection<GameObject> _gameObjects;
        public ObservableCollection<GameObject> GameObjects
        {
            get { return _gameObjects ?? (_gameObjects = new ObservableCollection<GameObject>()); }
        }

        public Player Player;

        public static Random random = new Random();
        
        public void NewLevel(int numberofEnemies)
        {
            GameObjects.Clear();
            Player = new Player()
            {
                MovementSpeed = 1,
                Location = new Point(GameParameters.GameAreaWidth / 2, GameParameters.GameAreaHeight / 2)
            };

            GameObjects.Add(Player);

            CreateEnemies(numberofEnemies);
        }

        private void CreateEnemies(int numberofEnemies)
        {
            Enumerable.Range(0, numberofEnemies).Select(x => new Enemy(Player)
            {
                MovementSpeed = 0.5,
                Location = new Point
                {
                    X = random.Next(-100, (int)GameParameters.GameAreaWidth + 100),
                    Y = random.Next(-100, (int)GameParameters.GameAreaHeight + 100)
                },
            }).ToList().ForEach(GameObjects.Add);
        }

        #endregion

        public void ToggleDirection(MoveDirections direction, bool value)
        {
            if (value && !Player.ActiveMoveDirections.Contains(direction))
                Player.ActiveMoveDirections.Add(direction);
            else if (!value)
                Player.ActiveMoveDirections.Remove(direction);
        }
    }
}