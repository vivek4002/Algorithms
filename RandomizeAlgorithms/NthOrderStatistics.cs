using System;
namespace RandomizeAlgorithms
{
    public class NthOrderStatistics
    {
        /* Complexity O(n)
        * depends upon how we choose the pivot same as quick sort
        * Only works for unique elements
        */
        public int FindNthHighestElement(int[] arr, int n)
        {
            // which element of the array we want?
            // i.e. if we want 3rd heighest in array of size 10 then
            // we actually want 8th index of sorted array.
            var element=arr.Length-n;
            return FindNthHighestElement(arr, 0, arr.Length-1,element);
        }

        private int FindNthHighestElement(int[] arr, int start, int end, int n)
        {
            var pivot= QuickSort.choosePivotElement(arr,start,end);
            var partitionIndex= QuickSort.PartitionArray(arr,pivot,start,end);
            if(n==partitionIndex) return arr[partitionIndex];
            if(n>partitionIndex) 
            {
                return FindNthHighestElement(arr, partitionIndex+1, end,n);
            }
            else
            {
                return FindNthHighestElement(arr, start,partitionIndex-1,n);
            }
        }
    }
}