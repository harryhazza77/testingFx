using Machine.Specifications;

namespace TestingFxTests
{
    [Subject("Mspec")]
    public class MspecExamples
    {
        private static bool Subject;
        private Establish context = () =>  Subject = false;
        private Because of = () => Subject = true;
        private It should_be_true = () => Subject.ShouldEqual(true);
    }
}