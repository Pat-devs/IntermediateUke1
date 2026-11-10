public class CourseView
{
    public string ReadChoice()
    {
        Console.WriteLine("1 Registrer | 2 Vis  | 3 Historikk | 0 Avslutt");
        return Console.ReadLine() ?? "0";
    }
    public string ReadName()
    {
        Console.Write("Navn: ");
        return (Console.ReadLine() ?? "").Trim();
    }
    public void ShowRegistrationResult(bool registered)
    {
        if (registered)
        {
            Console.WriteLine("Registrert.");
        }   
        else 
        { 
            Console.WriteLine("Avvist."); 
        }
    }
    public void ShowParticipants(List<string> participants, int capacity)
    {
        Console.WriteLine($"Deltakere: {participants.Count}/{capacity}");
        foreach (string participant in participants) 
        { 
            Console.WriteLine(participant); 
        }
    }
    public void ShowNames(List<string> items)
    {
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }    
    }
    public void ShowCounts(List<int> items)
    {
        foreach (int item in items)
        {
            Console.WriteLine(item);
        }  
    }
    public void ShowHeading(string heading)
    {
        Console.WriteLine(heading);
    }
    public void ShowUnkownChoice()
    {
        Console.WriteLine("Ukjent valg."); 
    }
}