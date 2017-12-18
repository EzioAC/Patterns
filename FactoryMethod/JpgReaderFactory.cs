namespace Patterns.FactoryMethod
{
    public class JpgReaderFactory : IImageReaderFactory
    {
        IImageReader IImageReaderFactory.GetReader()
        {
            return new JpgReader();
        }
    }
}