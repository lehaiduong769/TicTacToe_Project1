namespace MENACElib;
[Serializable]
class MatchBox
{
    private uint[] BeadCount;
    //innitialize a matchbox with 10 beads for each color
    private int TotalBeads;
    public State State { get; private set; }
    //represent the Tic Tac Toe state on the match box
    public MatchBox(State state)
    {
        BeadCount = Enumerable.Repeat((uint)10, 9).ToArray();
        State = state;
        foreach (var position in state.Os)
        {
            BeadCount[position] = 0;
        }
        foreach (var position in state.Xs)
        {
            BeadCount[position] = 0;
        }
        TotalBeads = 90 - 10 * state.GetTurnPassed();
    }
    public byte MakeChoose()
    {
        Random a = new();
        uint t = (uint)a.Next(TotalBeads);
        for (byte i = 0; i < 9; i++)
        {
            if (t < BeadCount[i]) return i;
            t -= BeadCount[i];
        }
        TotalBeads = Sum();
        return MakeChoose();
    }
    private int Sum()
    {
        uint s = 0;
        foreach (var item in BeadCount)
        {
            s += item;
        }
        return (int)s;
    }
    public void Learn(byte nextMove, bool isComputerWin)
    {
        if (BeadCount[nextMove] > 0)
            if (isComputerWin) BeadCount[nextMove]++;
            else BeadCount[nextMove]--;
    }
    public override string ToString()
    {
        string result = new string('=', 46) + "\n" + $"|{State.ToString(),-44}|\n" + new String('=', 46) + "\n|";
        string num = "|";
        for (int i = 0; i < 9; i++)
        {
            result += $"{i,4}|";
            num += $"{BeadCount[i],4}|";
        }
        return result + "\n" + num + "\n" + new string('=', 46);
    }

    public override bool Equals(object? obj)
    {
        return obj is MatchBox box &&
               box.State.Equals(State);
    }
}