using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cooking Cake", "Joao Lucas", 100);
        Video video2 = new Video("Dangerous Animals", "Discovery Chanel", 3400);
        Video video3 = new Video("Jesus Birthdate", "LDS Church", 2000);
        video1.ShowDetails();

        // Adding comments to video 1
        Comment comment1Video1 = new Comment("Peter", "I liked the video");
        Comment comment2Video1 = new Comment("Jhon", "Interesting!");
        Comment comment3Video1 = new Comment("Sarah", "I don't like it");
        video1._comments.Add(comment1Video1);
        video1._comments.Add(comment2Video1);
        video1._comments.Add(comment3Video1);

        // Adding comments to video 2
        Comment comment1Video2 = new Comment("Angelica", "That's funny");
        Comment comment2Video2 = new Comment("Felip", "Whooooooo, that animal is crazy");
        Comment comment3Video2 = new Comment("August", "LOL");
        video2._comments.Add(comment1Video2);
        video2._comments.Add(comment2Video2);
        video2._comments.Add(comment3Video2);

        // Adding comments to video 3
        Comment comment1Video3 = new Comment("Joseph", "I love it");
        Comment comment2Video3 = new Comment("Angelica", "I wanna know the church better");
        Comment comment3Video3 = new Comment("Lucas", "I felt the Spirit.");
        video3._comments.Add(comment1Video3);
        video3._comments.Add(comment2Video3);
        video3._comments.Add(comment3Video3);

        Console.WriteLine("Choose one option: ");
        Console.WriteLine("\t1. List all videos");
        Console.WriteLine("\t2. Show videos with comments");

        string answer = Console.ReadLine();
        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        switch (answer)
        {
            case "1":
                ShowAllVideos(_videos);
                break;
            case "2":
                foreach(Video video in _videos)
                {
                    video.ShowDetails();
                    Console.WriteLine("Comments:");
                    video.ShowComments();
                    Console.WriteLine($"\tTotal comments: {video.NumberOfComments()}");
                }
                break;
            default:
                Console.WriteLine("Invalid value!");
                break;

            
        }
    }

    public static void ShowAllVideos(List<Video> videos)
    {
        foreach(Video video in videos)
        {
            Console.WriteLine(video._title);
        }
    }
}