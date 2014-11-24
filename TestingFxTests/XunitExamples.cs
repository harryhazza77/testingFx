using System;
using Xunit;

namespace TestingFxTests
{
    public class XunitExamples
    {
        private readonly bool _actual;

        public XunitExamples()
        {
            _actual = true;
        }

        [Fact]
        public void ExceptionType()
        {
            Assert.Throws<ApplicationException>(() => { throw new ApplicationException(); });
        }

        [Fact]
        public void NormalAssert()
        {
            Assert.Equal(true, _actual);
        }
    }
}