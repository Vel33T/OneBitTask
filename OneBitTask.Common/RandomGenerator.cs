namespace OneBitTask.Common
{
    using System;
    using System.Text;

    public class RandomGenerator : IRandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUWXVYZabcdefghijklmnopqrstuwxvyz";

        private readonly string[] FirstNames = new string[] { "Pesho", "Gosho", "Tosho", "Ivan", "Kiril", "Luiza", "Mariq", "Elena", "Anna", "Nikol" };
        private readonly string[] LastNames = new string[] { "Peshov", "Goshov", "Toshov", "Ivanov", "Kirilov" };


        private Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public string RandomString(int minLength = 2, int maxLength = 20)
        {
            var result = new StringBuilder();
            var length = this.random.Next(minLength, maxLength + 1);
            for (int i = 0; i < length; i++)
            {
                result.Append(Letters[this.random.Next(0, Letters.Length)]);
            }

            return result.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string RandomFirstName()
        {
            return this.FirstNames[this.random.Next(0, FirstNames.Length)]; ;
        }

        public string RandomLastName()
        {
            return this.LastNames[this.random.Next(0, LastNames.Length)]; ;
        }
    }
}
