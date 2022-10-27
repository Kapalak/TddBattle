namespace FooBarQix.Tests
{
    public class UnitTest
    {
        [Test]
        public void TransformerComputeOutputString()
        {
            // Arrange
            int inputToTest = 1;
            var transformer = new Transformer();

            // Act
            string result = transformer.Compute(inputToTest);

            // Act & Assert
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}