using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "Tech Guy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks!"));

        Video video2 = new Video("OOP Basics", "Code Academy", 900);
        video2.AddComment(new Comment("Dana", "Loved this."));
        video2.AddComment(new Comment("Eli", "Clear explanation."));
        video2.AddComment(new Comment("Faith", "Perfect timing!"));

        Video video3 = new Video("Game Dev with Unity", "Indie Dev", 1200);
        video3.AddComment(new Comment("George", "Awesome content."));
        video3.AddComment(new Comment("Hannah", "Subbed!"));
        video3.AddComment(new Comment("Ian", "Very inspiring."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}
