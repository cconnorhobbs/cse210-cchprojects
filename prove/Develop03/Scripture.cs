public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] textWords = text.Split(" ");

        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        Random rand = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetRenderedText()
    {
        string display = _reference.DisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                display += "___ ";
            }
            else
            {
                display += word.GetText() + " ";
            }
        }

        return display;
    }
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}