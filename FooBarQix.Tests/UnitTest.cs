namespace FooBarQix.Tests
{
    public class UnitTest
    {

        [Test]
        public void TransformerComputeThrowsNotImplementedException()
        {
            // Arrange
            int inputToTest = 0;
            var transformer = new Transformer();

            // Act & Assert
            var ex = Assert.Throws<NotImplementedException>(() => transformer.Compute(inputToTest));
        }
    }
}