
class GoalManager
{

    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }

    public void Start()
    {


        while (true)
        {
            // Console.Clear();
            Console.WriteLine("\nWelcome to Eternal Quest!");
            DisplayPlayerInfo();
            Console.WriteLine("Choose a option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                CreateGoal();

            }
            else if (input == "2")
            {
                ListGoalDetails();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (input == "3")
            {
                SaveGoals();

            }
            else if (input == "4")
            {
                LoadGoals();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("**** Invalid input. Please choose a valid option. ****");
                Console.WriteLine("******************************************************");
                Thread.Sleep(500);
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {

        _goals.Select((goal, index) => $"{index + 1}. {goal.GetShortName()} ({goal.GetGoalType()})").ToList().ForEach(Console.WriteLine);

    }
    public void ListGoalDetails()
    {
        _goals.Select((goal, index) => $"{index + 1}. {goal.GetStringRepresentation()}").ToList().ForEach(Console.WriteLine);
    }

    public void CreateGoal()
    {

        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select a type of goal: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            try
            {
                Console.Write("Enter the name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points for your goal: ");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*****************************");
                Console.WriteLine($"Error creating goal try again");
                Console.WriteLine($"*****************************");
            }
        }
        else if (input == "2")
        {

            try
            {
                Console.Write("Enter the name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points for your goal: ");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*****************************");
                Console.WriteLine($"Error creating goal try again");
                Console.WriteLine($"*****************************");
            }

        }
        else if (input == "3")
        {

            try
            {
                Console.Write("Enter the name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points for your goal: ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("Enter the target number for your goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for your goal: ");
                int bonus = int.Parse(Console.ReadLine());

                Goal goal = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*****************************");
                Console.WriteLine($"Error creating goal try again");
                Console.WriteLine($"*****************************");
            }

        }
        else
        {
            Console.WriteLine($"*******************************************");
            Console.WriteLine("Invalid input. Please choose a valid option.");
            Console.WriteLine($"*******************************************");
        }

        Thread.Sleep(1000);
    }

    public void RecordEvent()
    {
        try
        {
            Console.WriteLine("Which goal did you accomplish?");
            ListGoalNames();
            Thread.Sleep(1000);
            Console.Write("Select a goal: ");
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > _goals.Count)
            {
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
            }
            Goal selectedGoal = _goals[input - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();

            if (selectedGoal is CheckListGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"*****************************");
            Console.WriteLine($"Error selecting goal try again");
            Console.WriteLine($"*****************************");
        }



    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {

                writer.WriteLine(goal.GetDetailString());
                Thread.Sleep(1000);
            }
        }
    }

    public void LoadGoals()
    {
        try
        {
            Console.Write("Enter the filename to load your goals: ");
            string filename = Console.ReadLine();
            Thread.Sleep(1000);
            if (File.Exists(filename))
            {
                _goals.Clear();
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        int points = int.Parse(parts[3]);
                        Goal goal = new SimpleGoal(parts[1], parts[2], points);
                        if (isComplete)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else if (type == "CheckListGoal")
                    {
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        int points = int.Parse(parts[3]);
                        Goal goal = new CheckListGoal(parts[1], parts[2], points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else
                    {
                        int points = int.Parse(parts[3]);
                        Goal goal = new EternalGoal(parts[1], parts[2], points);
                        _goals.Add(goal);
                    }
                }
                Thread.Sleep(500);
                Console.WriteLine($"*************************");
                Console.WriteLine("Goals loaded successfully!");
                Console.WriteLine($"*************************");
            }
            else
            {
                Console.WriteLine($"*********************************************");
                Console.WriteLine("File not found. Please enter a valid filename.");
                Console.WriteLine($"*********************************************");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"****************************************************************************");
            Console.WriteLine($"Your file is not valid or an error occurred while loading. Please try again.");
            Console.WriteLine($"****************************************************************************");
        }
    }


}
