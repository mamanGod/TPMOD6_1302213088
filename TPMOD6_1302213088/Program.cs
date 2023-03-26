// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    int id;
    string title;
    int playCount;

    public SayaTubeVideo(string t)
    {
        this.title = t;
        Random r = new Random();
        id = r.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int pt)
    {
        this.playCount += pt;
    }

    public void PrintVideosDetails()
    {
        Console.WriteLine("id       : " + this.id);
        Console.WriteLine("title    : " + this.title);
        Console.WriteLine("playCount: " + this.playCount);
    }

    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Rahman");
        video.IncreasePlayCount(17);
        video.PrintVideosDetails();
    }
}
