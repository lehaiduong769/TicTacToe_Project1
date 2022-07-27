namespace MENACElib;
[Serializable]
class State
{
    public List<byte> Os { get; private set; }
    public List<byte> Xs { get; private set; }

    public State()
    {
        Os = new List<byte>();
        Xs = new List<byte>();
    }

    public State(List<byte> a, List<byte> b)
    {
        Os = a;
        Xs = b;
    }
    public State(List<byte> c)
    {
        Os = new();
        Xs = new();
        for (int i = 0; i < c.Count; i++)
        {
            if (i % 2 == 0) Os.Add(c[i]);
            else Xs.Add(c[i]);
        }
    }

    public override string ToString()
    {
        string result = "O: ";
        foreach (var item in Os)
        {
            result += item + "  ";
        }
        result += ",X: ";
        foreach (var item in Xs)
        {
            result += item + "  ";
        }
        return result;
    }
    public int GetTurnPassed() => Os.Count + Xs.Count;

    public override bool Equals(object? obj)
    {
        return obj is State state &&
               state.Os.SequenceEqual(this.Os) &&
               state.Xs.SequenceEqual(this.Xs);
    }
}