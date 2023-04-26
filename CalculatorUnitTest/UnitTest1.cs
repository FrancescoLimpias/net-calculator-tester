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
        [Test(Description = "Test for calculator's addition")]
        public void TestAdd(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Add(numberA, numberB), Is.EqualTo(expectedResult), $"Addition has unexpected result: {numberA} + {numberB} ");
        }


        [TestCase(0, 0, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, -1, 2)]
        [TestCase(20, 400, -380)]
        [Test(Description = "Test for calculator' subtraction")]
        public void TestSubtract(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Subtract(numberA, numberB), Is.EqualTo((float)expectedResult), $"Subtraction has unexpected result: {numberA} - {numberB} ");
        }

    }
}