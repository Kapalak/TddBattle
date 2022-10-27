namespace FooBarQix.Tests
{
    public class UnitTest
    {
        [Test]
        public void TransformerComputeOutputString()
        {
            // Arrange
            var random = new Random();
            int inputToTest = random.Next();
            var transformer = new Transformer();

            // Act
            string result = transformer.Compute(inputToTest);

            // Act & Assert
            Assert.That(inputToTest.ToString(), Is.EqualTo(result));
        }
    }
}