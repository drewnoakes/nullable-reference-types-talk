#nullable enable

using System;

public class FairgroundGame
{
    private readonly DodgyCoin _coin = new DodgyCoin();

    private bool TryGetPrize(out string prize)
    {
        if (_coin.Flip() == "Heads")
        {
            prize = "Martian";
            return true;
        }

        prize = null;
        return false;
    }

    public void Play()
    {
        if (TryGetPrize(out string prize))
        {
            Console.WriteLine($"You won a {prize.ToUpper()}!!!");
        }
        else
        {
            Console.WriteLine("Try again?");
        }
    }
}
