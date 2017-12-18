namespace Patterns.FactoryMethod
{
    public interface IImageReaderFactory
    {
         IImageReader GetReader();
    }
}