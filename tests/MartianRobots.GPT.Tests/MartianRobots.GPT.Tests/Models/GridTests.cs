using MartianRobots.GPT.Models;
using Xunit;

namespace MartianRobots.GPT.Tests.Models
{
    public class GridTests
    {
        [Fact]
        public void TestGridIsPositionValid()
        {
            var grid = new Grid(5, 3);

            Assert.True(grid.IsPositionValid(0, 0));
            Assert.True(grid.IsPositionValid(5, 3));
            Assert.False(grid.IsPositionValid(6, 3));
            Assert.False(grid.IsPositionValid(5, 4));
        }

        [Fact]
        public void TestGridAddScent()
        {
            var grid = new Grid(5, 3);
            grid.AddScent(1, 3);

            Assert.True(grid.HasScent(1, 3));
            Assert.False(grid.HasScent(2, 3));
        }
    }
}
