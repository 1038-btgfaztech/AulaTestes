using Moq;
using SimpleCalculatorDomain;

namespace SimpleCalculatorTests
{
    public class SimpleCalculatorTests
    {
        private Mock<INumberService> numberServiceMock;
        private SimpleCalculator calculator;


        public SimpleCalculatorTests()
        {
            numberServiceMock = new Mock<INumberService>();
            calculator = new SimpleCalculator(numberServiceMock.Object);
        }

        [Fact]
        public void Div_ValidInput_RerturnsValidResult()
        {
            //Arrange
            numberServiceMock.Setup(x => x.GetNumberA()).Returns(6);
            numberServiceMock.Setup(x => x.GetNumberB()).Returns(3);

            //Act
            var result = calculator.Div();


            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Sum_ValidInput_RerturnsValidResult()
        {
            //Act
            var result = calculator.Sum(3, 2);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Sub_ValidInput_RerturnsValidResult()
        {
            //Act
            var result = calculator.Sub(5, 2);

            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 0, 0)]
        public void Times_ValidInput_RerturnsValidResult(int a, int b, int expected)
        { 
            var actual = calculator.Times(a, b);

            Assert.Equal(expected, actual);
        }

        //[Theory]
        //[InlineData(6, 3, 2)]
        //public void Div_ValidInput_RerturnsValidResult(int a, int b, int expected)
        //{
        //    var result = calculator.Div(a, b);

        //    Assert.Equal(expected, result);
        //}

        //[Theory]
        //[InlineData(6)]
        //public void Div_ByZero_ThrowsException(int a)
        //{
        //    Action action = () => calculator.Div(a, 0);

        //    Assert.Throws<DivideByZeroException>(action);
        //}
    }
}