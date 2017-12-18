namespace Patterns.Adapter
{
    public class DataOperationAdapter : IDataOperation
    {
        private QuickSort qs;
        private BinarySearch bs;

        public DataOperationAdapter()
        {
            qs = new QuickSort();
            bs = new BinarySearch();
        }
        int IDataOperation.Search(int[] array, int target)
        {
            return bs.BinarySearchArray(array,target);
        }

        void IDataOperation.Sort(int[] array)
        {
            qs.QuickSortArray(array);
        }
    }
}