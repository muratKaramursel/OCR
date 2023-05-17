namespace OCR.Core
{
    public abstract class OCRHelperBase : IOCRHelper
    {
        protected OCRHelperBase()
        {
        }

        public abstract List<string> GetTextListFromImage(string imageFilePath);
    }
}