Course course = new Course(3);

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

        bool registered = course.TryRegister(name);
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
        ShowParticipants(course.GetParticipants(), course.Capacity);
    }
    else 
    { 
        Console.WriteLine("Ukjent valg."); 
    }
}


static void ShowParticipants(List<string> participants, int capacity)
{
    Console.WriteLine($"Deltakere: {participants.Count}/{capacity}");
    foreach (string participant in participants) 
    { 
        Console.WriteLine(participant); 
    }
}