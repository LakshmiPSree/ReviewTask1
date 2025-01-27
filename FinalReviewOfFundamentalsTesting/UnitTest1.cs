using FinalReviewOfFundamentals;


namespace FinalReviewOfFundamentalsTesting
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void AdditionReturnsInteger()
        {
            int a = 3;
            int b = 4;
            int expected = a + b;
            int actual = Calculator.Add(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubtractionReturnsInteger()
        {
            int a = 4;
            int b = 2;
            int expected = a - b;
            int actual = Calculator.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplicationReturnsDouble()
        {
            double a = 3;
            double b = 4.2;
            double expected = a * b;
            double actual = Calculator.Multiply(a,b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivisionReturnsDouble()
        {
            double a = 6;
            double b = 4;
            double expected = a / b;
            double actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}