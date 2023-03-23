namespace MartianRobots.GPT.Models
{
    public class Grid
    {
        private int Width { get; }
        private int Height { get; }
        private HashSet<(int, int)> Scents { get; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            Scents = new HashSet<(int, int)>();
        }

        public bool IsWithinBounds(int x, int y) => x >= 0 && x <= Width && y >= 0 && y <= Height;

        public bool HasScent(int x, int y) => Scents.Contains((x, y));

        public void AddScent(int x, int y) => Scents.Add((x, y));
    }
}
