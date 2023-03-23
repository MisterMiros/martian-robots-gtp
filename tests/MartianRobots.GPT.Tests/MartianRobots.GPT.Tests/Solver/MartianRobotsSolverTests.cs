using Xunit;
using MartianRobots.GPT.Solver;

namespace MartianRobots.GPT.Tests.Solver
{
    public class MartianRobotsSolverTests
    {
        [Fact]
        public void TestSampleInput()
        {
            string input = "5 3\r\n1 1 E\r\nRFRFRFRF\r\n3 2 N\r\nFRRFLLFFRRFLL\r\n0 3 W\r\nLLFFFLFLFL";
            string expectedOutput = "1 1 E\n3 3 N LOST\n2 3 S";

            string result = MartianRobotsSolver.Solve(input);

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void TestEmptyInput()
        {
            string input = "";
            string expectedOutput = "";

            string result = MartianRobotsSolver.Solve(input);

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void TestRobotDoesNotMove()
        {
            string input = "5 3\r\n1 1 E\r\n";
            string expectedOutput = "1 1 E";

            string result = MartianRobotsSolver.Solve(input);

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void TestRobotMoveOffGrid()
        {
            string input = "5 3\r\n1 1 N\r\nFFFFF";
            string expectedOutput = "1 3 N LOST";

            string result = MartianRobotsSolver.Solve(input);

            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void TestRobotMoveOffGridAndLeaveScent()
        {
            string input = "5 3\r\n1 1 N\r\nFFFFF\r\n1 1 N\r\nFFFFF";
            string expectedOutput = "1 3 N LOST\n1 3 N";

            string result = MartianRobotsSolver.Solve(input);

            Assert.Equal(expectedOutput, result);
        }
    }
}
