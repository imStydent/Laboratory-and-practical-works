using System.Text;

namespace Task1
{
    internal class ExtendedRandom : Random
    {
        public string GetString(int stringLength, double digitsPercentage)
        {
            Random random = new();
            StringBuilder stringBuilder = new();
            char symbol;

            for (int i = 0; i < stringLength; i++)
            {
                if (random.Next(100) <= digitsPercentage)
                    symbol = ((char)random.Next('0', '9' + 1));
                else
                   symbol = ((char)random.Next('a', 'z' + 1));
                stringBuilder.Append(symbol);
            }
            return stringBuilder.ToString();
        }
    }
}
