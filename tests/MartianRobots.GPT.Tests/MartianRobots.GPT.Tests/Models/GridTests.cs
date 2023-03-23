using MartianRobots.GPT.Models;
using Xunit;

namespace MartianRobots.GPT.Tests.Models
{
    public class GridTests
    {
        [Fact]
        public void TestGridIsWithinBounds()
        {
            var grid = new Grid(5, 3);

            Assert.True(grid.IsWithinBounds(0, 0));
            Assert.True(grid.IsWithinBounds(5, 3));
            Assert.False(grid.IsWithinBounds(6, 3));
            Assert.False(grid.IsWithinBounds(5, 4));
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
