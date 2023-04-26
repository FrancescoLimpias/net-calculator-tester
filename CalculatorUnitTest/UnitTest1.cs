using net_calculator_tester;

namespace CalculatorUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, -1, 0)]
        [TestCase(20, 400, 420)]
        [Test(Description = "Test for add calculator")]
        public void TestAdd(float numberA, float numberB, float expectedResult)
        {

            Assert.That(Calculator.Add(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }
    }
}