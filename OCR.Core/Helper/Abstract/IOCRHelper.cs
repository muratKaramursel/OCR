namespace OCR.Core
{
    public interface IOCRHelper
    {
        List<string> GetTextListFromImage(string imageFilePath);
    }
}