public class Course
{
    private List<string> _participants = new List<string>();
    public int Capacity { get; private set; }

    public int Count
    {
        get { return _participants.Count; }
    }

    public Course(int capacity)
    {
        Capacity = capacity;
    }

    public bool TryRegister(string name)
    {
        if (name.Length == 0)
        {
            return false;
        }
        if (_participants.Contains(name))
        {
            return false;
        }
        if (_participants.Count >= Capacity)
        {
            return false;
        }

        _participants.Add(name);
        return true;
    }

    public List<string> GetParticipants()
    {
        return new List<string>(_participants);
    }

}