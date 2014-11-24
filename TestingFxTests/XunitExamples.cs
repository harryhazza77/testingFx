using System;
using FluentAssertions;
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

        [Fact]
        public void ExceptionTypeAndMessageFluent()
        {
            Action act = () => { throw new ApplicationException("xunit"); };
            act.ShouldThrow<ApplicationException>().WithMessage("xunit");
        }

        [Fact]
        public void NormalAssertFluent()
        {
            _actual.Should().BeTrue();
        }
    }
}