using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianRobots.GPT.Tests.Models
{
    public class RobotTests
    {
        [Fact]
        public void TestRobotTurn()
        {
            var robot = new Robot(0, 0, Orientation.N);
            robot.Turn(Instruction.L);
            Assert.Equal(Orientation.W, robot.Orientation);
            robot.Turn(Instruction.R);
            Assert.Equal(Orientation.N, robot.Orientation);
        }

        [Fact]
        public void TestRobotMove()
        {
            var robot = new Robot(0, 0, Orientation.N);
            var grid = new Grid(5, 3);

            robot.Move(grid);
            Assert.Equal(1, robot.Y);

            robot.Orientation = Orientation.E;
            robot.Move(grid);
            Assert.Equal(1, robot.X);
        }

        [Fact]
        public void TestRobotMoveOffGrid()
        {
            var robot = new Robot(0, 3, Orientation.N);
            var grid = new Grid(5, 3);

            Assert.Throws<InvalidOperationException>(() => robot.Move(grid));
        }
    }
}
