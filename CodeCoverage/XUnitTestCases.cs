using System;
using Xunit;

namespace XUnitCodeCoverage
{
    public class XUnitTestCases
    {
        [Fact]

        public void TestHello()
        {
            var message = "Hello";
            Assert.Equal("Hello", message);
        }
    }
}
