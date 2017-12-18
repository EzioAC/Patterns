namespace Patterns.AbstractFactory
{
    public class OracleElementFactory : IDBElementFactory
    {
        Connect IDBElementFactory.CreateConnect()
        {
            return new OracleConnect();
        }

        Statement IDBElementFactory.CreateStatement()
        {
            return new OracleStatement();
        }

    }
}