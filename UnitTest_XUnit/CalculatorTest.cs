using Xunit;
using System.Collections.Generic;
using System.Collections;

namespace UnitTest_XUnit
{
    public class CalculatorTest
    {
        private Calculator _alvoDoTeste = new Calculator();

        [Fact]
        public void SumOfTwoNumbersMustBeTheSameAsTheResult()
        {
            _alvoDoTeste.Add(5);
            _alvoDoTeste.Add(4);

            Assert.Equal(9, _alvoDoTeste.Value);
        }

        [Theory]
        [InlineData(11, 5, 6)]
        public void SumOfTwoNumbersMustBeTheSameAsTheResult_Theory(int expectedValue, int value1, int value2)
        {
            _alvoDoTeste.Add(value1);
            _alvoDoTeste.Add(value2);

            Assert.Equal(expectedValue, _alvoDoTeste.Value);
        }

        [Theory]
        //[MemberData(nameof(DataForTestOfSum))]
        [ClassData(typeof(ClassWithDataForTestOfSum))]
        public void SumOfManyNumbersMustBeTheSameAsTheResult_Theory(int expectedValue, int[] values)
        {
            foreach (int value in values)
            {
                _alvoDoTeste.Add(value);
            }

            Assert.Equal(expectedValue, _alvoDoTeste.Value);
        }

        public static IEnumerable<object[]> DataForTestOfSum()
        {
            yield return new object[] { 13, new int[] { 5, 8 } };
            yield return new object[] { 10, new int[] { 5, 2, 2, 1 } };
            yield return new object[] { -10, new int[] { 10, -20 } };
            yield return new object[] { 6, new int[] { 3, 3 } };
        }

        public class ClassWithDataForTestOfSum : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 13, new int[] { 5, 8 } };
                yield return new object[] { 10, new int[] { 5, 2, 2, 1 } };
                yield return new object[] { -10, new int[] { 10, -20 } };
                yield return new object[] { 6, new int[] { 3, 3 } };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
