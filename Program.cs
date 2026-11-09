const int Capacity = 3;
List<string> participants = new List<string>();
while (true)
{
    Console.WriteLine("1 Registrer | 2 Vis | 0 Avslutt");
    string? choice = Console.ReadLine();
    if (choice == "0" || choice == null) 
    {
        break;
    }
    if (choice == "1")
    {
        Console.Write("Navn: ");
        string name = (Console.ReadLine() ?? "").Trim();

        bool registered = TryRegister(participants, name, Capacity);
        if (registered)
        {
            Console.WriteLine("Registrert.");
        }   
        else 
        { 
            Console.WriteLine("Avvist."); 
        }    
    } 
    else if (choice == "2")
    {
        ShowParticipants(participants, Capacity);
    }
    else 
    { 
        Console.WriteLine("Ukjent valg."); 
    }
}

static bool TryRegister(List<string> participants, string name, int capacity)
{
    if (name.Length == 0)
    {
        return false;
    } 
    if (participants.Contains(name))
    {
        return false;
    }
    if (participants.Count >= capacity)
    {
        return false;
    }

    participants.Add(name);
    return true;
}

static void ShowParticipants(List<string> participants, int capacity)
{
    Console.WriteLine($"Deltakere: {participants.Count}/{capacity}");
    foreach (string participant in participants) 
    { 
        Console.WriteLine(participant); 
    }
}