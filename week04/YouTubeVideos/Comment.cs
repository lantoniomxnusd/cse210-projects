public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;

    }

    public string GetUserName()
    {
        return _userName;
    }

    public void setUserName(string value)
    {
        _userName = value;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string value)
    {
        _text = value;
    }
}