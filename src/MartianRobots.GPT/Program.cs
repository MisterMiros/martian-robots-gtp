
using MartianRobots.GPT.Solver;

namespace MartianRobots.GPT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "5 3\r\n1 1 E\r\nRFRFRFRF\r\n3 2 N\r\nFRRFLLFFRRFLL\r\n0 3 W\r\nLLFFFLFLFL";
            string result = MartianRobotsSolver.Solve(input);
            Console.WriteLine(result);
        }
    }
}