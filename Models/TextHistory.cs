public class TextHistory
{
    private List<string> _items = new List<string>();
    public int Count
    {
        get  { return _items.Count; }
    }

    public void Add(string item)
    {
        _items.Add(item);
    }

    public List<string> GetSnapShot()
    {
        return new List<string>(_items);
    }
}