public class NumberHistory
{
    private List<int> _items = new List<int>();
    public int Count
    {
        get  { return _items.Count; }
    }

    public void Add(int item)
    {
        _items.Add(item);
    }

    public List<int> GetSnapShot()
    {
        return new List<int>(_items);
    }
}