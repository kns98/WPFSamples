using System.Threading;
using System.Windows;

namespace WPFSamples.Samples.SamsGameSample
{
    public class Enemy : GameObject
    {
        public Timer MoveTimer;

        public Enemy(GameObject target)
        {
            Target = target;

            Size = new Size(15, 15);
            MoveTimer = new Timer(x => Move(), null, 0, 50);
        }

        private GameObject Target;

        private void Move()
        {
            var vector = Point.Subtract(Target.Location, Location);
            vector.Normalize();

            var newlocation = Point.Add(Location, new Vector()
            {
                X = 10 * vector.X * MovementSpeed + (random.Next(-2, 2)),
                Y = 10 * vector.Y * MovementSpeed + (random.Next(-2, 2))
            });
            Location = AdjustToGameArea(newlocation);
        }
    }
}