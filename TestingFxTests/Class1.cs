using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

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
        public void NormalAssert()
        {
            Assert.AreEqual(true, _actual);
        }
    }
}