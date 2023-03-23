using MartianRobots.GPT.Enums;

namespace MartianRobots.GPT.Models
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Orientation Orientation { get; set; }
        public bool Lost { get; set; }

        public Robot(int x, int y, Orientation orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
            Lost = false;
        }

        public void ExecuteInstruction(Instruction instruction, Grid grid)
        {
            if (!Lost)
            {
                switch (instruction)
                {
                    case Instruction.L:
                        TurnLeft();
                        break;
                    case Instruction.R:
                        TurnRight();
                        break;
                    case Instruction.F:
                        MoveForward(grid);
                        break;
                }
            }
        }

        private void TurnLeft() => Orientation = (Orientation)(((int)Orientation + 3) % 4);

        private void TurnRight() => Orientation = (Orientation)(((int)Orientation + 1) % 4);

        private void MoveForward(Grid grid)
        {
            int newX = X;
            int newY = Y;

            switch (Orientation)
            {
                case Orientation.N:
                    newY++;
                    break;
                case Orientation.E:
                    newX++;
                    break;
                case Orientation.S:
                    newY--;
                    break;
                case Orientation.W:
                    newX--;
                    break;
            }

            if (grid.IsWithinBounds(newX, newY))
            {
                X = newX;
                Y = newY;
            }
            else if (!grid.HasScent(X, Y))
            {
                Lost = true;
                grid.AddScent(X, Y);
            }
        }

        public override string ToString() => $"{X} {Y} {Orientation}{(Lost ? " LOST" : "")}";
    }
}
