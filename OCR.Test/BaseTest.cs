using OCR.Core;

namespace OCR.Test
{
    internal class BaseTest
    {
        private static readonly object _ocrHelperLock = new();
        private static IOCRHelper _ocrHelper;

        public static IOCRHelper OCRHelper
        {
            get
            {
                if (_ocrHelper == null)
                    lock (_ocrHelperLock)
                        _ocrHelper ??= OCRHelperFactory.GetInstance().Create();

                return _ocrHelper;
            }
        }
    }
}