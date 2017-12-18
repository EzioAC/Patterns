namespace Patterns.AbstractFactory
{
    public class MySQLElementFactory:IDBElementFactory
    {
        Connect IDBElementFactory.CreateConnect()
        {
            return new MySQLConnect();
        }

        Statement IDBElementFactory.CreateStatement()
        {
            return new MySQLStatement();
        }

    }
}