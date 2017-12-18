namespace Patterns.Adapter
{
    public interface IDataOperation
    {  
        void Sort(int[] array);
        int Search(int[] array,int target);
    }
}