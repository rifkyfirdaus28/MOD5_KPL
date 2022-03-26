public class SayaTubeVideo
{
    int id;
    string title;
    int playCount;


    public SayaTubeVideo()
    {
        Random generate = new Random();
        this.id = generate.Next(0, 100000);
        this.playCount = 0;
    }

    public void IncreaseplayCount(int angka)
    {
        playCount = playCount + angka;
    }

    public int GetPlaycount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("title: " + title);
        Console.WriteLine("id: " + id);
        Console.WriteLine("playCount:" + playCount);
    }


}


public class SayaTubeUser
{
    private int id;
    internal string username;
    List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Random shuffle = new Random();
        this.id = shuffle.Next(0, 100000);
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (SayaTubeVideo video in this.uploadedVideos)
        {
            total += video.getPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
        this.video = this.video;

    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User : " + this.video);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " Judul : " + this.uploadedVideos[i].getTitle());
        }
    }
}



