namespace FooBarQix
{
    public class Transformer
    {
        public string Compute(int input)
        {
            if (input % 3 == 0)
            {
                return "FooFoo";
            }
            else if (input.ToString().Contains("3"))
            {
                return "Foo";
            }

            return input.ToString();
        }
    }
}
