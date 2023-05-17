namespace OCR.Core
{
    public class OCRHelperFactory : IOCRHelperFactory
    {
        private static readonly object _ocrHelperFactoryLock = new();
        private static OCRHelperFactory _ocrHelperFactory;

        private OCRHelperFactory()
        {
        }

        public static OCRHelperFactory GetInstance()
        {
            if (_ocrHelperFactory == null)
                lock (_ocrHelperFactoryLock)
                    _ocrHelperFactory ??= new OCRHelperFactory();

            return _ocrHelperFactory;
        }

        public IOCRHelper Create()
        {
            return new OCRHelperTesseract();
        }
    }
}