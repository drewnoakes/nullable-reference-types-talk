class BrexitVoter
{
    private string _selection;

    public string Selection
    {
        get
        {
            if (_selection == null)
            {
                _selection = ComplexDecision();
            }

            return _selection;
        }
    }

    private static string ComplexDecision()
    {
        return "No";
    }
}
