using Xbehave;
using Xunit;

namespace TestingFxTests
{
    public class XbehaveExamples
    {
        [Scenario(DisplayName = "Booleans")]
        public void Booleans(bool x, bool y, bool expected, bool actual)
        {
            "Given a boolean"
                .Given(() => x = true);

            "And another boolean"
                .And(() => y = true);

            "When I compare them"
                .When(() => actual = x == y);

            "Then they should be equal"
                .Then(() => Assert.True(actual));
        }
    }
}