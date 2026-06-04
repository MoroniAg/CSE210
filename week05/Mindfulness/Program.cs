using System;

/*
This program is a console application that provides users with a selection of mindfulness activities to choose from. The user can select from three different activities: Breathing Activity, Reflexting Activity, and Listing Activity. Each activity has its own unique description and duration.
The Breathing Activity guides the user through a simple breathing exercise to help them relax. The Reflexting Activity encourages the user to reflect on their experiences and feelings, while the Listing Activity prompts the user to list things that bring them joy and gratitude.
The program uses a base class called Activity, which contains common functionality for all activities, such as
displaying start and end messages, showing a spinner animation, and displaying a countdown timer. Each specific activity class (BreathingActivity, ReflextingActivity, ListingActivity) inherits from the Activity class and implements its own Run method to execute the activity.
The user can exit the program by selecting the "Exit" option from the menu. Overall,
this program aims to provide a simple and interactive way for users to engage in mindfulness activities and promote relaxation and self-reflection.

*/

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Mindfulness Activities!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflexting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {

                Console.WriteLine("You have selected the Breathing Activity.");
                Console.WriteLine("This activity will help you relax by guiding you through a simple breathing exercise.");
                Console.WriteLine("How long would you like to do this activity? (in seconds)");
                int duration = int.Parse(Console.ReadLine());

                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "A simple breathing exercise to help you relax.", duration);
                breathingActivity.Run();

            }
            else if (choice == "2")
            {
                List<string> prompts = new List<string> {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

                List<string> questions = new List<string> {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
                Console.Clear();
                Console.WriteLine("You have selected the Reflexting Activity.");
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine("How long would you like to do this activity? (in seconds)");
                int duration = int.Parse(Console.ReadLine());

                ReflextingActivity reflextingActivity = new ReflextingActivity("Reflexting Activity", "Reflect on your experiences and feelings.", duration, prompts, questions);
                reflextingActivity.Run();
            }
            else if (choice == "3")
            {
                List<string> prompts = new List<string> {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };
                Console.Clear();
                Console.WriteLine("You have selected the Listing Activity.");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("How long would you like to do this activity? (in seconds)");
                int duration = int.Parse(Console.ReadLine());

                ListingActivity listingActivity = new ListingActivity("Listing Activity", "List things that bring you joy and gratitude.", prompts.Count, duration, prompts);
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for participating in the Mindfulness Activities. Goodbye!");
                break;
            }
        }

    }
}