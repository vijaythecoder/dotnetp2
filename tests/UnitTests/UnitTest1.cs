using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_WorksWithTwoNegativeIntegers()
        {
            var expected = true;
            var a = -5;
            var b = 6;
            var actual = IsSumPositive(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(true, -2, 2)]
        [InlineData(false, -7, -5)]
        [InlineData(false, -9, 5)]
        public void Add_SumIsPositive(bool exp, int n1, int n2)
        {
            Assert.Equal(exp, IsSumPositive(n1, n2));
        }

        bool IsSumPositive(int n1, int n2)
        {
            if (n1 + n2 >= 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
