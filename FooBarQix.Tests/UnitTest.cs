namespace FooBarQix.Tests
{
    public class UnitTest
    {

        [Test]
        public void FooBarQixComputeZeroReturnsZero()
        {
            // Arrange
            string expectedResult = "0";
            int inputToTest = 0;
            var fooBarQix = new Transformer();

            // Act
            var actualResult = fooBarQix.Compute(inputToTest);

            // Assert
            //Assert.AreEqual(expectedResult, actualResult);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}