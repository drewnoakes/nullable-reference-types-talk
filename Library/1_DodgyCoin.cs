using System;

public class DodgyCoin
{
    private readonly Random _random = new Random();

    public string Flip()
    {
        var i = _random.Next(1000);

        if (i > 500)
            return "Heads";
        else if (i > 0)
            return "Tails";
        else
            return null;
    }
}

#region Usage

public class TwoUp
{
    private readonly DodgyCoin _coin1 = new DodgyCoin();
    private readonly DodgyCoin _coin2 = new DodgyCoin();

    public string Toss()
    {
        var isHeads1 = _coin1.Flip().Equals("Heads");
        var isHeads2 = _coin2.Flip().Equals("Heads");

        switch ((isHeads1, isHeads2))
        {
            case (true, true): return "Win";
            case (false, false): return "Lose";
            default: return "Try again";
        }
    }
}

#endregion
