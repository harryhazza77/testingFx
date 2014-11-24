using NSpec;

namespace TestingFxTests
{
    public class NspecExamples : nspec
    {
        private bool _actual;

        private void before_each()
        {
            _actual = true;
        }

        private void it_should_be_true()
        {
            _actual.should_be(true);
        }
    }
}