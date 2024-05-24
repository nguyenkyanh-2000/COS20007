namespace QueueApplication;

public class IntegerQueue
{
    public List<int> _elements;
    
    public IntegerQueue()
    {
        _elements = new List<int>();
    }
    
    public int Count => _elements.Count;
    
    public void Enqueue(int toAdd)
    {
        _elements.Add(toAdd);
    }

    public int Dequeue()
    {
        int result = _elements[0];
        _elements.RemoveAt(0);
        return result;
    }
}