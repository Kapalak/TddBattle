namespace FooBarQix
{
    public class Transformer
    {
        public string Compute(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0)
            {
                result += "FooFoo";
            }
            else if (input.ToString().Contains("3"))
            {
                result += "Foo";
            }
            if (input % 3 == 0 && input.ToString().Contains("5") && input % 5 == 0)
            {
                result = "FooBarBar";
            }
            else if (input.ToString().Contains("5") && input % 3 == 0)
            {
                result = "FooBar";
            }
            else if (input.ToString().Contains("5") && input % 5 == 0)
            {
                result = "BarBar";
            }
            else if (input.ToString().Contains("5"))
            {
                result += "Bar";
            }
            else if (input % 5 == 0)
            {
                result += "Bar";
            }
            

            if (result == string.Empty)
                return input.ToString();
            return result;
        }
    }
}
