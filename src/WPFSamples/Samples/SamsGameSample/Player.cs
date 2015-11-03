using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace WPFSamples.Samples.SamsGameSample
{
    public class Player : GameObject
    {
        public readonly List<MoveDirections> ActiveMoveDirections = new List<MoveDirections>();

        public Timer MoveTimer;

        public Player()
        {
            Size = new Size(30, 30);
            MoveTimer = new Timer(x => MovePlayer(), null, 0, 50);
        }

        private void MovePlayer()
        {
            int verticaloffset = 0;
            int horizontaloffset = 0;

            if (ActiveMoveDirections.Contains(MoveDirections.Up))
                verticaloffset = -10;
            else if (ActiveMoveDirections.Contains(MoveDirections.Down))
                verticaloffset = 10;

            if (ActiveMoveDirections.Contains(MoveDirections.Left))
                horizontaloffset = -10;
            else if (ActiveMoveDirections.Contains(MoveDirections.Right))
                horizontaloffset = 10;

            var newlocation = Point.Add(Location, new Vector(horizontaloffset * MovementSpeed, verticaloffset * MovementSpeed));
            Location = AdjustToGameArea(newlocation);
        }
    }
}