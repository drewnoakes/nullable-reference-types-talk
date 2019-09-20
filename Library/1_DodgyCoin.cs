using System;

public class DodgyCoin
{
    private readonly Random _random = new Random();

    public string Flip()
    {
        return _random.Next(1000) switch
        {
            var i when i > 500 => "Heads",
            var i when i > 0   => "Tails",
            _ => null
        };
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

        return (isHeads1, isHeads2) switch
        {
            (true,  true)  => "Win",
            (false, false) => "Lose",
            (_,     _)     => "Try again"
        };
    }
}

#endregion
