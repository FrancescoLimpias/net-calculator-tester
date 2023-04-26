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
        [TestCase(-1, -1, -2)]
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
        [TestCase(-1, -1, 0)]
        [TestCase(20, 400, -380)]
        [Test(Description = "Test for calculator' subtraction")]
        public void TestSubtract(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Subtract(numberA, numberB), Is.EqualTo((float)expectedResult), $"Subtraction has unexpected result: {numberA} - {numberB} ");
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(-1, -1, 0)]
        [TestCase(1, -1, 1)]
        [TestCase(20, 400, (float)0.05)]
        [Test(Description = "Test for calculator' division")]
        public void TestDivide(float numberA, float numberB, float expectedResult)
        {
            Assume.That(numberB != 0.0, "The dividend is 0 -> invalid operation");
            Assert.That(Calculator.Divide(numberA, numberB), Is.EqualTo((float)expectedResult), $"Division has unexpected result: {numberA} / {numberB} ");
        }


        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, -1, 1)]
        [TestCase(20, 400, 8000)]
        [Test(Description = "Test for calculator' multiplication")]
        public void TestMultiply(float numberA, float numberB, float expectedResult)
        {
            Assert.That(Calculator.Multiply(numberA, numberB), Is.EqualTo((float)expectedResult), $"Multiplication has unexpected result: {numberA} * {numberB} ");
        }


        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 2, 0)]

        [TestCase(1, 0, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, -1, -1)]

        [TestCase(20, 400, Double.PositiveInfinity)]
        [TestCase(400, 20, Double.PositiveInfinity)]
        [Test(Description = "Test for calculator' exponentiation")]
        public void TestPower(float numberA, float numberB, double expectedResult)
        {
            Assume.That(
                !(numberA == 0.0
                && numberB == 0.0),
                "Base and exponent are 0! -> invalid operation");

            Assert.That(Calculator.Power(numberA, numberB), Is.EqualTo((double)expectedResult), $"Exponentiation has unexpected result: {numberA} ^ {numberB} ");
        }

    }
}