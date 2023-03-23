namespace MartianRobots.GPT
{
    public static class MartianRobotsSolver
    {
        public static string Solve(string input)
        {
            var lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var gridSpecs = lines[0].Split(' ');
            var grid = new Grid(int.Parse(gridSpecs[0]), int.Parse(gridSpecs[1]));

            var output = new List<string>(); for (int i = 1; i < lines.Length; i += 2)
            {
                var position = lines[i].Split(' ');
                var x = int.Parse(position[0]);
                var y = int.Parse(position[1]);
                var orientation = (Orientation)Enum.Parse(typeof(Orientation), position[2]);

                var robot = new Robot(x, y, orientation);

                var instructions = lines[i + 1];
                foreach (var instructionChar in instructions)
                {
                    var instruction = (Instruction)Enum.Parse(typeof(Instruction), instructionChar.ToString());
                    robot.ExecuteInstruction(instruction, grid);
                }

                output.Add(robot.ToString());
            }

            return string.Join(Environment.NewLine, output);
        }
    }
}
