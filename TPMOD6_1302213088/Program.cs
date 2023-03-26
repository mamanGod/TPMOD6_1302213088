// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
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
        Debug.Assert(t.Length < 100 && t != null);
    }

    public void IncreasePlayCount(int pt)
    {
        Debug.Assert(pt < 10000000);
        try
        {
            checked { this.playCount += pt;}
        }
        catch(OverflowException error)
        {
            Console.WriteLine(error.Message);
        }
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
        for(int i = 0; i < 1000; i++)
        {
            video.IncreasePlayCount(17);
        }
        video.PrintVideosDetails();
    }
}
