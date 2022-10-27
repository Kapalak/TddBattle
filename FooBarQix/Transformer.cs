namespace FooBarQix
{
    public class Transformer
    {
        public string Compute(int input)
        {
            string result = string.Empty;
            result = genericFunction(input, 3, "Foo", result);
            result = genericFunction(input, 5, "Bar", result);
            result = genericFunction(input, 7, "Qix", result);




            return result == string.Empty ? input.ToString() : result;
        }
        private string genericFunction(int input,int n, string chaine, string result)
        {
            if (input % n == 0)
            {
                result += chaine;

            }
             if (input.ToString().Contains(n.ToString()))
            {
                result += chaine;
            }
            return result;

        }
    }
}
