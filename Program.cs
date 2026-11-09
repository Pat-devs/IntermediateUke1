List<string> n = new List<string>();
while (true)
{
Console.WriteLine("1 Registrer | 2 Vis | 0 Avslutt");
string? x = Console.ReadLine();
if (x == "0" || x == null) { break; }
if (x == "1")
{
Console.Write("Navn: ");
string s = (Console.ReadLine() ?? "").Trim();
if (s.Length > 0)
{
if (!n.Contains(s))
{
if (n.Count < 3)
{
n.Add(s);
Console.WriteLine("Registrert.");    
}          
else { Console.WriteLine("Avvist."); }      
}     
else { Console.WriteLine("Avvist."); }      
}   
else { Console.WriteLine("Avvist."); }    
} 
else if (x == "2")
{
Console.WriteLine($"Deltakere: {n.Count}/3");
foreach (string v in n) { Console.WriteLine(v); }
}
else { Console.WriteLine("Ukjent valg."); }
}