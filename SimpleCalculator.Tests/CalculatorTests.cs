// CalculatorTests.cs
using Xunit;

namespace SimpleCalculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnDifference_WhenGivenTwoNumbers()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnProduct_WhenGivenTwoNumbers()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_ShouldReturnQuotient_WhenGivenTwoNonZeroNumbers()
        {
            // Arrange
            double a = 6;
            double b = 3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            double a = 6;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}