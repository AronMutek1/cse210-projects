using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating some Video objects
        Video video1 = new Video("Cooking 101", "Chef John", 600);
        Video video2 = new Video("Travel Vlog: Paris", "Alex Traveler", 1200);
        Video video3 = new Video("Workout Routine", "Fitness Guru", 800);

        // Adding comments to the videos
        video1.AddComment(new Comment("Alice", "Great video! I loved the recipes."));
        video1.AddComment(new Comment("Bob", "Thanks for the tips, Chef John."));
        video1.AddComment(new Comment("Charlie", "I tried your recipe, and it turned out delicious!"));

        video2.AddComment(new Comment("David", "I dream of visiting Paris someday."));
        video2.AddComment(new Comment("Eve", "Such a beautiful city!"));

        video3.AddComment(new Comment("Frank", "This workout really pushed me to my limits!"));
        video3.AddComment(new Comment("Grace", "I’ll start this routine tomorrow."));
        video3.AddComment(new Comment("Henry", "Great exercises, I felt stronger right away."));

        // Putting the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterating through the list of videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
