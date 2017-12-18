namespace Patterns.Adapter
{
    public class Client
    {
        public void Test()
        {
            IDataOperation obj = new DataOperationAdapter();
            //obj.Sort();
            //obj.Search();
        }
    }
}