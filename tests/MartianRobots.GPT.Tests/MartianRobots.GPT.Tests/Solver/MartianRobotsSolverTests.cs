using Xunit;
using MartianRobots;

namespace MartianRobots.GPT.Tests.Solver
{
    namespace MartianRobots.Tests.Solver
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

            // Add more test methods for different scenarios as needed.
        }
    }

}
