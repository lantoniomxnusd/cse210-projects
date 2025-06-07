using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Ribeye Steak on the Grill", "Certified Angus Beef", 214);
        video1.AddComment(new Comment("William Willy", "Bought for my son. We have had one for years, works great. Can cook indirect and smoke meat"));
        video1.AddComment(new Comment("Roy Price", "Watched a few now, and this one's to the point, cheers dude."));
        video1.AddComment(new Comment("MyFireVideos", "I come back to this video every time i bbq ribeye over charcoal. Thanks!"));

        Video video2 = new Video("Rylie Mills is the Seahawks Newest WEAPON", "Legion of 12s", 766);
        video2.AddComment(new Comment("Ralph Dahlberg", "Finally someone is talking about Mills. He’s probably the pick I was the most excited about. Huge steal."));
        video2.AddComment(new Comment("Kevin Thomas", "Im passing your content on to my buddies.  I love what you're doing here man!"));
        video2.AddComment(new Comment("Zidavey", "Great content!"));

        Video video3 = new Video("Are junior devs screwed?", "THEO -t3.gg", 3041);
        video3.AddComment(new Comment("Internet Doggo", "Oh boy, can't wait until all the Sr. devs retire and there's no Jr. devs to replace them!!"));
        video3.AddComment(new Comment("Andrewhme", "God have mercy on my soul, I just want a job to have a house and a family, I will do my best, I wish luck to those who are starting like me"));
        video3.AddComment(new Comment("mr-process", "As someone that still is learning, it's real hard to continue while seeing these news everyday from everyone."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");


            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetUserName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }

}