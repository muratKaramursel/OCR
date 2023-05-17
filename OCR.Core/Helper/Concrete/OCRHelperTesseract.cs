using Tesseract;

namespace OCR.Core
{
    public class OCRHelperTesseract : OCRHelperBase
    {
        public override List<string> GetTextListFromImage(string imageFilePath)
        {
            List<string> textList = new();

            using (TesseractEngine tesseractEngine = new("./StaticFiles/Tesseract", "tur", EngineMode.Default))
            using (Pix pix = Pix.LoadFromFile(imageFilePath))
            using (Page page = tesseractEngine.Process(pix))
                textList.Add(page.GetText());

            return textList;
        }
    }
}