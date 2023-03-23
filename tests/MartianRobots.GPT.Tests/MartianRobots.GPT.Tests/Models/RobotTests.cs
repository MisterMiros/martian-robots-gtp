using MartianRobots.GPT.Enums;
using MartianRobots.GPT.Models;
using Xunit;

namespace MartianRobots.GPT.Tests.Models
{
    public class RobotTests
    {
        [Fact]
        public void TestRobotTurn()
        {
            var robot = new Robot(0, 0, Orientation.N);
            robot.ExecuteInstruction(Instruction.L);
            Assert.Equal(Orientation.W, robot.Orientation);
            robot.ExecuteInstruction(Instruction.R);
            Assert.Equal(Orientation.N, robot.Orientation);
        }

        [Fact]
        public void TestRobotMove()
        {
            var robot = new Robot(0, 0, Orientation.N);
            var grid = new Grid(5, 3);

            robot.ExecuteInstruction(Instruction.F, grid);
            Assert.Equal(1, robot.Y);

            robot.Orientation = Orientation.E;
            robot.ExecuteInstruction(Instruction.F, grid);
            Assert.Equal(1, robot.X);
        }
    }
}
