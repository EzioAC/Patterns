namespace Patterns.FactoryMethod
{
    public class GifReaderFactory : IImageReaderFactory
    {

        IImageReader IImageReaderFactory.GetReader()
        {
            return new GifReader();
        }
    }
}