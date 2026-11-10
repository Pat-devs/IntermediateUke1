public class History<T>
{
    private List<T> _items = new List<T>();
    public int Count
    {
        get { return _items.Count; }
    }
    public void Add (T item)
    {
        _items.Add(item);
    }
    public List<T> GetSnapShot()
    {
        return new List<T>(_items);
    }
}