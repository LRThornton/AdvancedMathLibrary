using AdvancedMathLibrary;
using Xunit;

namespace TestAdvanced_MathLibrary {
    public class TestIntMathLib {


        [Fact]
        public void TestDivideByZero() {
            System.Action ZeroDenominator = () => Math.Divide(1, 0);
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-10, 15, -25)]
        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }

        [Theory]
        [InlineData(25, 50, 25)]
        [InlineData(4, 7, 3)]
        [InlineData(45, 50, 5)]       
            public void TestSubtract(int expected, int a, int b) {
            Assert.Equal(expected, Math.Subtract(a, b));
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(21, 7, 3)]
        [InlineData(48, 4, 12)]
            public void TestMultiply(int expected, int a, int b) {
            Assert.Equal(expected, Math.Multiply(a, b));
        }
        [Theory]
        [InlineData(3, 15, 5)]
        [InlineData(3, 21, 7)]
        [InlineData(4, 20, 5)]
            public void TestDivide(int expected, int a, int b) {
            Assert.Equal(expected, Math.Divide(a, b));

        }




        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        
        public void TestAbsoluteValue(int input, int expected) {       
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }             
    }
}
