public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetRenderedText()
    {
        if (_hidden)
        {
            return "___";
        }
        else
        {
            return _text;
        }
    }
    public string GetText()
    {
        return _text;
    }
}
