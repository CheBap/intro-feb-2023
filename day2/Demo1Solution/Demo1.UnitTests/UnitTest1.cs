namespace Demo1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(8, 2, 10)]
        [InlineData(2, 2, 4)]
        public void CanAddTwoNumbersTheory(int a , int b, int expected)
        {

            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}