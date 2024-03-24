internal class Program
{
    public static void Main(string[] args)
    {
        string title = "Tutorial Design By Contract - Irji Syahrul";
        SayaTubeVideo video = new SayaTubeVideo(title);

        video.PrintVideoDetails();

        video.IncreasePlayCount(10);

        video.PrintVideoDetails();
    }
}