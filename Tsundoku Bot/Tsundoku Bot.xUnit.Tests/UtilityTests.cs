using Xunit;

namespace Tsundoku_Bot.xUnit.Tests
{
    public class UtilityTests
    {
        [Fact]
        public void FirstTest()
        {
            const int expected = 5;

            int actual = Utilities.Util(expected);

            Assert.Equal(expected, actual);
        }
    }
}
