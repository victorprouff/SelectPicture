namespace SelectPictures;

public class Picture
{
    public Picture(string url, string fileName, bool isDeleted = false)
    {
        Url = url;
        FileName = fileName;
        IsDeleted = isDeleted;
    }
    
    public string Url { get; }
    public string FileName { get; }
    
    public string? Source { get; private set; }

    public bool IsDeleted { get; private set; }

    public void SetDelete(bool isDeleted)
    {
        IsDeleted = isDeleted;
    }

    public void SetSource(string source)
    {
        Source = source;
    }
}