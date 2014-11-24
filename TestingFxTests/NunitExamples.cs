using System;
using FluentAssertions;
using NSpec;
using NUnit.Framework;

namespace TestingFxTests
{
    [TestFixture]
    public class NunitExamples
    {
        private bool _actual;

        [SetUp]
        public void BeforeEach()
        {
            _actual = true;
        }

        [Test]
        [ExpectedException(typeof (ApplicationException))]
        public void ExceptionType()
        {
            throw new ApplicationException();
        }

        [Test]
        public void ExceptionTypeFluent()
        {
            Action act = () => { throw new ApplicationException("nunit"); };
            act.ShouldThrow<ApplicationException>().WithMessage("nunit");
        }

        [Test]
        public void NormalAssertFluent()
        {
            _actual.Should().BeTrue();
        }
    }
}