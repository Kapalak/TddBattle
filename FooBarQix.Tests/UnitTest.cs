namespace FooBarQix.Tests
{
    public class Tests
    {

        [Test]
        public void FooBarQixComputeZeroReturnsZero()
        {
            // Arrange
            string expectedResult = "0";
            int inputToTest = 0;
            var fooBarQix = new FooBarQix();

            // Act
            var actualResult = fooBarQix.Compute(inputToTest);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}