public class Quest
{
    public int ID;
    public string Name;
    public string Description;

    public Quest(int id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
    }

    public static void GetQuest()
    {
        Player player = new Player("Serdin", "B", "Sword", 1, 1);
        List<Quest> playerQuests = new();
        
        for (int i = 0; i < World.Quests.Count; i++)
        {
            if (player.CurrentLocation == "F")
            {
                if (World.Quests[i].Name == "Clear the farmer's field")
                {
                    Console.WriteLine("“I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest.");
                        playerQuests.Add(World.Quests[i]);
                        //Player Location
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest();
                    }
                }
            }
            else if (player.CurrentLocation == "A")
            {
                if (World.Quests[i].Name == "Clear the alchemist's garden")
                {
                    Console.WriteLine("“Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest.");
                        playerQuests.Add(World.Quests[i]);
                        //Player Location
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest();
                    }
                }
            }
            else if (player.CurrentLocation == "B")
            {
                if (World.Quests[i].Name == "Collect spider silk")
                {
                    Console.WriteLine("“I shalt releaseth the town folks of their feareth!”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest.");
                        playerQuests.Add(World.Quests[i]);
                        //Player Location
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest();
                    }
                }
            }
        }
    }
}