namespace Task3
{
    internal class Program
    {
        static async Task WriteFileNumbersAsync(string fileName, int stringAmount)
        {
            Random random = new();
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                for (int i = 0; i < stringAmount; i++)
                    await writer.WriteLineAsync($"Число: {random.Next()}");
            }
        }

        static void Main()
        {
            WriteFileNumbersAsync(@"C:\Temp\ispp-21\LabWork22", 10);
        }
    }
}
