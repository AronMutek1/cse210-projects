public class Comment
{
    // Attributes
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Properties
    public string Name
    {
        get { return _name; }
    }

    public string Text
    {
        get { return _text; }
    }
}
