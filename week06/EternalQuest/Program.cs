using System;

class Program
{
    static void Main(string[] args)
    {

        /* 
         Create an instance of GoalManager and start the application, which will display the menu and handle user interactions.
         The GoalManager class is responsible for managing the goals, including creating new goals, listing existing goals, saving and loading goals from a file, and recording events for the goals. The Start method will run an infinite loop that displays the menu and processes user input until the user chooses to quit the application.
         The user can create new goals, list all goals, save goals to a file, load goals from a file, and record events for the goals. The application will continue to run until the user selects the option to quit.
         New Features:
         1. Added a new atribute "type" to the Goal class to distinguish between different types of goals (SimpleGoal and EternalGoal).
         2. Set type of goal in the record for save this information into the file.
         3. Load File and create a respective goal based on the type of goal in the file.  
         4. Added validations for user input to ensure that the application can handle invalid inputs gracefully.
         5. Implemented error handling for file operations to prevent crashes and provide feedback to the user when issues arise during saving or loading goals.
        
        */

        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}