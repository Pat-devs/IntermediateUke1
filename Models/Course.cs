public class Course
{
    private List<string> _participants = new List<string>();
    private History<string> _nameHistory = new History<string>();
    private History<int> _countHistory = new History<int>();
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
        _nameHistory.Add(name);
        _countHistory.Add(Count);
        return true;
    }
    public List<string> GetNameHistory()
    {
        return _nameHistory.GetSnapShot();
    }
    public List<int> GetCountHistory()
    {
        return _countHistory.GetSnapShot();
    }

    public List<string> GetParticipants()
    {
        return new List<string>(_participants);
    }

}