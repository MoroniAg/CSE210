using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demo of Video and Comment classes:\n");


        var introToCSharp = new Video("Introduction to C#", "OpenGG", 600);
        introToCSharp.AddComment(new Comment("Alice", "Great video!"));
        introToCSharp.AddComment(new Comment("Bob", "Thanks for the explanation."));
        introToCSharp.AddComment(new Comment("Carlos", "Where are the resources?"));


        var oopInCSharp = new Video("OOP in C#", "MiqueasCode", 820);
        oopInCSharp.AddComment(new Comment("Diana", "Excellent clarity."));
        oopInCSharp.AddComment(new Comment("Edu", "This helped me a lot for the assignment."));
        oopInCSharp.AddComment(new Comment("Fatima", "Can you show more examples?"));


        var collectionsAndLists = new Video("Collections and Lists", "Companionship Red", 450);
        collectionsAndLists.AddComment(new Comment("Gonzalo", "Very practical."));
        collectionsAndLists.AddComment(new Comment("Hana", "What about arrays?"));
        collectionsAndLists.AddComment(new Comment("Ian", "Thanks!"));
        collectionsAndLists.AddComment(new Comment("Joan", "Good pacing."));

        var videoList = new List<Video> { introToCSharp, oopInCSharp, collectionsAndLists };

        foreach (var video in videoList)
        {
            video.Display();
            Console.WriteLine("\n-------------------------\n");
        }
    }


}