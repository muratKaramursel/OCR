namespace OCR.Test
{
    internal class OCRHelperTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("C:\\Users\\murat.karamursel\\Desktop\\test.jpg")]
        public void GetTextListFromImageTest(string imageFilePath)
        {
            List<string> textList = OCRHelper.GetTextListFromImage(imageFilePath);

            foreach (string text in textList)
                Console.WriteLine(text);

            Assert.Pass();
        }
    }
}