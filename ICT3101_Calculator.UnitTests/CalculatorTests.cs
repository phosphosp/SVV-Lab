using Moq;
namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            // Arrange 
            _calculator = new Calculator();

            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
                fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act          
            double result = _calculator.Add(10, 20);
            // Assert 
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act          
            double result = _calculator.Subtract(10, 20);
            // Assert 
            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act          
            double result = _calculator.Multiply(10, 20);
            // Assert 
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act          
            double result = _calculator.Divide(10, 20);
            // Assert 
            Assert.That(result, Is.EqualTo(0.5));
        }

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        //{
        //    Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        //}

        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-100)]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(3.5)]
        [TestCase(2.7)]
        [TestCase(-1.2)]
        public void Factorial_WithNonIntegerInput_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WithZeroAsInput_ResultEqualToOne()
        {
            double result = _calculator.Factorial(0);
            Assert.That(() => result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        [TestCase(10, 3628800)]
        public void Factorial_WithPositiveIntegers_ResultReturnsExpected(double a, double expected)
        {
            double result = _calculator.Factorial(a);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, -1)]
        [TestCase(-1, 0)]
        [TestCase(-1, -1)]
        public void AreaTriangle_WithZeroOrNegativesAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.AreaTriangle(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 6, 9)]
        [TestCase(10, 20, 100)]
        [TestCase(100, 200, 10000)]
        public void AreaTriangle_WithPositiveIntegers_ResultReturnsExpected(double a, double b, double expected)
        {
            double result = _calculator.AreaTriangle(a, b);
            Assert.That(() => result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void AreaCircle_WithZeroOrNegativesAsInputs_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.AreaCircle(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, 3.142)]
        [TestCase(10, 314.2)]
        [TestCase(100, 31420)]
        public void AreaCircle_WithPositiveIntegers_ResultReturnsExpected(double a, double expected)
        {
            double result = _calculator.AreaCircle(a);
            Assert.That(() => result, Is.EqualTo(expected));
        }


        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert 
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert 
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert 
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act         
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act         
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert 
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert 
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act          
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert 
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act         
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act         
            // Assert 
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void GenMagicNum_WithValidIndex0_PositiveValue()
        {
            // MagicNumbers[0] = 10 -> doubled to 20
            IFileReader fileReader = new FileReader();
            double result = _calculator.GenMagicNum(0, fileReader);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void GenMagicNum_WithValidIndex1_NegativeValue()
        {
            // MagicNumbers[1] = -5 -> doubled to -10 -> converted to positive 10
            IFileReader fileReader = new FileReader();
            double result = _calculator.GenMagicNum(1, fileReader);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void GenMagicNum_WithOutOfRangeIndex_ReturnsZero()
        {
            // If index >= file length, no assignment -> result remains 0 -> converted to 0
            IFileReader fileReader = new FileReader();
            double result = _calculator.GenMagicNum(99, fileReader);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_WithNonIntegerInput_RoundsDown()
        {
            // Input 2.4 -> choice = 2 -> MagicNumbers[2] = 42 -> doubled = 84
            IFileReader fileReader = new FileReader();
            double result = _calculator.GenMagicNum(2.4, fileReader);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WithValidIndex0_UsingMock_Returns84()
        {
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WithValidIndex1_UsingMock_Returns84()
        {
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WithOutOfRangeIndex_UsingMock_Returns0()
        {
            double result = _calculator.GenMagicNum(99, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_WithNonIntegerInput_UsingMock_Returns84()
        {
            double result = _calculator.GenMagicNum(1.4, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }
    }
}