using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increaseAmount)
    {
        playCount += increaseAmount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Play Count: {0}", playCount);
    }

  
}
