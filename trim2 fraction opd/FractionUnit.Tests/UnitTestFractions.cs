using FractionLibrary;

namespace FractionUnit.Tests
{
    public class UnitTestFractions
    {
        public Fraction fraction = new Fraction();

        [Fact]
        //test if the class has a property called Numerator
        public void TestHasPropertyNumerator() 
        {
            fraction.Numerator = 8;
            Assert.Equal(8, fraction.Numerator);
            Assert.NotNull(fraction.GetType().GetProperty("Numerator"));
        }

        [Fact]
        //test if the class has a property called Denominator
        public void TestHasPropertyDenominator() 
        {
            fraction.Denominator = 9;
            Assert.Equal(9 , fraction.Denominator);
            Assert.NotNull(fraction.GetType().GetProperty("Denominator"));
        }
        [Fact]
        //test if the denominator is not zero
        public void TestDenominatorNotZero() 
        {
            Assert.Throws<DivideByZeroException>(() => new Fraction(1, 0));
        }
        [Fact]
        //test if the add method works
        public void TestAdd() 
        {
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Add(fractionTest2);
            Assert.Equal(5, result.Numerator);
            Assert.Equal(4, result.Denominator);

            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(-29, result.Numerator);
            Assert.Equal(21, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(5, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        //test if the subtract method works
        public void TestSubtract() 
        {
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(4, result.Denominator);

            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(21, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-6, result.Numerator);
            Assert.Equal(5, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        //test if the multiply method works
        public void TestMultiply() 
        {
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(3, result.Numerator);
            Assert.Equal(8, result.Denominator);

            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(10, result.Numerator);
            Assert.Equal(21, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(-7, result.Numerator);
            Assert.Equal(20, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);

            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        //test if the divide method works
        public void TestDivide() 
        {
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(14, result.Numerator);
            Assert.Equal(15, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(-5, result.Numerator);
            Assert.Equal(7, result.Denominator);

            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            Assert.Throws<DivideByZeroException>(() => fractionTest1.Divide(fractionTest2));

            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            Assert.Throws<DivideByZeroException>(() => fractionTest1.Divide(fractionTest2));
        }
        [Fact]
        //test if the reciprocal method works
        public void TestReciprocal() 
        {
            Fraction fractionTest = new Fraction(1, 2);
            Fraction result = fractionTest.Reciprocal();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(1, result.Denominator);

            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Reciprocal();
            Assert.Equal(-3, result.Numerator);
            Assert.Equal(2, result.Denominator);

            fractionTest = new Fraction(0, 8);
            Assert.Throws<DivideByZeroException>(() => fractionTest.Reciprocal());
        }
        [Fact]
        //test if the invert method works
        public void TestInvert() 
        {
            Fraction fractionTest = new Fraction(1, 2);
            Fraction result = fractionTest.Invert();
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Invert();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            fractionTest = new Fraction(-2, -3);
            result = fractionTest.Invert();
            Assert.Equal(-2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            fractionTest = new Fraction(0, 8);
            result = fractionTest.Invert();
            Assert.Equal(0, result.Numerator);
        }
        [Fact]
        //test if the simplify method works
        public void TestSimplify() 
        {
            Fraction fractionTest = new Fraction(150, 66);
            Fraction result = fractionTest.Simplify();
            Assert.Equal(25, result.Numerator);
            Assert.Equal(11, result.Denominator);

            fractionTest = new Fraction(-246, 2);
            result = fractionTest.Simplify();
            Assert.Equal(-123, result.Numerator);
            Assert.Equal(1, result.Denominator);

            fractionTest = new Fraction(0, 8);
            result = fractionTest.Simplify();
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);

        }
        [Fact]
        //test if the result method works
        public void TestResult() 
        {
            Fraction fractionTest = new Fraction(1, 2);
            double result = fractionTest.Result();
            Assert.Equal(0.5, result);

            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Result();
            Assert.Equal(-0.6666666666666666, result);

            fractionTest = new Fraction(0, 8);
            result = fractionTest.Result();
            Assert.Equal(0, result);
        }
        [Fact]
        //test if the ToString method works
        public void TestToString() 
        {
            Fraction fractionTest = new Fraction(1, 2);
            string result = fractionTest.ToString();
            Assert.Equal("1/2", result);

            fractionTest = new Fraction(-2, 3);
            result = fractionTest.ToString();
            Assert.Equal("-2/3", result);

            fractionTest = new Fraction(0, 8);
            result = fractionTest.ToString();
            Assert.Equal("0", result);
        }

    }
}