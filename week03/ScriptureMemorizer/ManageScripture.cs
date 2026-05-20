class ManageScripture
{
    private List<Scripture> _scriptures { get; set; }

    public ManageScripture()
    {
        _scriptures = new List<Scripture>();
        LoadScriptures();
    }

    public void LoadScriptures()
    {
        try
        {
            string[] lines = File.ReadAllLines("scriptures.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 2)
                {
                    string reference = parts[0].Trim();
                    string text = parts[1].Trim();
                    Scripture scripture = new Scripture(new Reference(reference), text);
                    _scriptures.Add(scripture);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
    }

    public Scripture GetScripture()
    {
        Random random = new Random();
        int randomIndex = random.Next(_scriptures.Count);
        Console.WriteLine($"Selected Scripture: {randomIndex}");  
        Scripture selectedScripture = _scriptures[randomIndex];
        return selectedScripture;
    }
}