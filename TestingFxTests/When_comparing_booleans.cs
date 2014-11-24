using Machine.Specifications;

namespace TestingFxTests
{
    [Subject("Booleans")]
    public class When_comparing_booleans
    {
        private static bool Subject;
        private Establish context = () =>  Subject = false;
        private Because of = () => Subject = true;
        private It should_be_true = () => Subject.ShouldEqual(true);
    }
}