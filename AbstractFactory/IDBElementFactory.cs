namespace Patterns.AbstractFactory
{
    public interface IDBElementFactory
    {
         Connect CreateConnect();
         Statement CreateStatement();
    }
}