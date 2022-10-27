namespace FooBarQix.Tests
{
    public class UnitTest
    {

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "FooFoo")]
        [TestCase(13, "Foo")]
        [TestCase(136, "Foo")]
        [TestCase(5, "BarBar")]
        [TestCase(10, "Bar")]
        [TestCase(15, "FooBarBar")]
        [TestCase(51, "FooBar")]
        [TestCase(7, "QixQix")]
        [TestCase(21, "FooQix")]
        [Test]
        public void TransformerComputeReturnsExpected(int input, string expectedOutput)
        {
            // Arrange
            var transformer = new Transformer();

            // Act
            string result = transformer.Compute(input);
           
            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
        
      }
}