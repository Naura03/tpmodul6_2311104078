class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Naura Aisha Zahira");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}
