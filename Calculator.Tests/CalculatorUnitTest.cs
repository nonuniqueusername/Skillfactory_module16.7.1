namespace Calculator.Tests
{
    public class CalculatorUnitTest
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(300, calculator.Additional(150, 150));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(300, calculator.Subtraction(450, 150));
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(300, calculator.Miltiplication(10, 30));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(300, calculator.Division(3000, 10));
        }
    }
}