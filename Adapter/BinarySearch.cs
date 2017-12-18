using System;

namespace Patterns.Adapter
{
    public class BinarySearch
    {
        public int BinarySearchArray(int[] array,int target)
        {
            return Array.BinarySearch(array,0,array.Length,target);
        }
    }
}