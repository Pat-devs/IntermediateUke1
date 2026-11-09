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
        if (name.Length > 0)
        {
            if (!participants.Contains(name))
            {
                if (participants.Count < Capacity)
                {
                    participants.Add(name);
                    Console.WriteLine("Registrert.");    
                }          
                else 
                { 
                    Console.WriteLine("Avvist."); 
                }      
            }     
            else 
            { 
                Console.WriteLine("Avvist."); 
            }      
        }   
        else 
        { 
            Console.WriteLine("Avvist."); 
        }    
    } 
    else if (choice == "2")
    {
        Console.WriteLine($"Deltakere: {participants.Count}/{Capacity}");
        foreach (string participant in participants) 
        { 
            Console.WriteLine(participant); 
        }
    }
    else 
    { 
        Console.WriteLine("Ukjent valg."); 
    }
}