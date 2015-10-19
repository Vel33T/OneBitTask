namespace OneBitTask.Common
{
    public interface IRandomGenerator
    {
        int RandomNumber(int min, int max);

        string RandomString(int minLength = 2, int maxLength = 20);

        string RandomFirstName();

        string RandomLastName();
    }
}
