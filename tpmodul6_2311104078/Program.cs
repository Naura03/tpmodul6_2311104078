class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Naura Aisha Zahira");
            video.PrintVideoDetails();

            Console.WriteLine("\nMenambah play count secara normal:");
            video.IncreasePlayCount(100);
            video.PrintVideoDetails();

            Console.WriteLine("\nMenguji exception dengan jumlah play count besar:");
            video.IncreasePlayCount(15000000); // Harusnya error
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
