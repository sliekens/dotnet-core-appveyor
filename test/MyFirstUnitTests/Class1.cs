using Xunit;

namespace MyFirstUnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void PassingTest2()
        {
            Assert.Equal(4, Multiply(2, 2));
        }

        [Fact(Skip = "Known bug: Multiply(int, int) seems to add numbers instead of multiplying them. Cannot fix before the PR in #4578 is merged.")]
        public void FailingTest()
        {
            Assert.Equal(10, Multiply(2, 5));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        int Multiply(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6, Skip = "Known bug: 6 is even across all instances of Universe. TODO: update implementation of IPhysics to account for parallel universes.")]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}