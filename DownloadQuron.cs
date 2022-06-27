using System.Net;
public class MusicDowmloadQuron
{
    public int i=9;
    public static void 
    Download(int number)
    {
        var numberOfQuron = number.ToString("D3");
        var  download = new WebClient();
        download.DownloadFile($"https://www.youtube.com/watch?v=MW8mQGcYqMA",$"E:\\c#\\MusicDownload\\file\\ vidoc#.mp4");   
        Console.WriteLine($"{number} yklandi");
    }

}
