namespace MENACElib;
using Newtonsoft.Json;
[Serializable]
class MENACE
{
    public List<MatchBox>[] MatchBoxOfTurn { get; private set; }
    public MENACE()
    {
        MatchBoxOfTurn = new List<MatchBox>[9];
        for (int i = 0; i < 9; i++)
        {
            MatchBoxOfTurn[i] = new();
        }
    }
    private bool Add(MatchBox matchBox)
    {
        var temp = MatchBoxOfTurn[matchBox.State.GetTurnPassed()];
        if (temp.Contains(matchBox)) return false;
        temp.Add(matchBox);
        return true;
    }
    public byte nextMove(State state)
    {
        Add(new MatchBox(state));
        return MatchBoxOfTurn[state.GetTurnPassed()].Find(x => x.State.Equals(state)).MakeChoose();
    }
    public void Learn(List<byte> moves, string winner)
    {
        for (int i = 0; i < moves.Count; i++)
        {
            var state = new State(moves.GetRange(0, i));
            Add(new MatchBox(state));
            if (winner == "O" || winner == "Computer") MatchBoxOfTurn[i].Find(x => x.State.Equals(state)).Learn(moves[i], true);
            else if (winner == "X" || winner == "Computer") MatchBoxOfTurn[i].Find(x => x.State.Equals(state)).Learn(moves[i], false);
        }
    }
    public void Train()
    {
        string path = @"D:\VTC\8.Project 1\tictactoe\MENACElib\tempRecord.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                var b = sr.ReadLine().Split(",");
                string a = b[1];
                System.Console.WriteLine(a);
                Learn((new List<char>(a)).ConvertAll(x => (byte)(x - '0')).GetRange(0, a.Length - 1), b[2]);
            }
        }
    }
    public void Upload() 
    {
        using (StreamWriter sw = new(@"D:\VTC\8.Project 1\tictactoe\MENACElib\data.json"))
        {
            sw.WriteLine(JsonConvert.SerializeObject(this.MatchBoxOfTurn));

        }
    }
    public void Download()
    {
        using (StreamReader sr = new(@"D:\VTC\8.Project 1\tictactoe\MENACElib\data.json"))
        {
            var M = sr.ReadLine();
            System.Console.WriteLine(M);
            this.MatchBoxOfTurn = JsonConvert.DeserializeObject<List<MatchBox>[]>(M);
        }
    }
}
/*
class Serializer
{
    public void MENACESerializer(MENACE menace, string filePath)
    {
        using (StreamWriter sw = new(filePath))
        {
            sw.WriteLine(JsonConvert.SerializeObject(menace.MatchBoxOfTurn));

        }

    }
    public List<MatchBox>[] BinaryDeserializer(string filePath)
    {
        using (StreamReader sr = new(filePath))
        {
            var M = sr.ReadLine();
            System.Console.WriteLine(M);
            return JsonConvert.DeserializeObject<List<MatchBox>[]>(M);
        }
    }
}
*/