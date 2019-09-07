using System;
using Xunit;

namespace SomeLibTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // comment in test
            int expteced = 1;
            int actual = 1;
            Assert.Equal(expteced, actual);
        }
    }
}
