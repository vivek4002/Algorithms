using System;
namespace RandomizeAlgorithms
{
    /* Complexity Average and best case: O(nlogn)
    * Complexity Worst case O(n^2)
    * Complexity depends upon how we chose the pivot elemnt
    *best pivet should devide array atleast in 30%-70% ratio
    * Inplace sort no extra space required
    */
    public class QuickSort
    {
        public int[] Sort(int[] arr)
        {
            return Sort(arr, 0, arr.Length-1);
        }

        private int[] Sort(int[] arr, int start, int end)
        {
            if(start>=end) return arr;
            var pivot= choosePivotElement(arr, start, end);
            int partitionIndex=PartitionArray(arr, pivot, start, end);
            Sort(arr, start, partitionIndex-1);
            Sort(arr, partitionIndex+1, end);
            return arr;
        }

        public static int PartitionArray(int[] arr, int pivot, int start, int end)
        {
            int i= pivot+1;
            for(int j=start+1;j<=end;j++){
                if(arr[j]<arr[pivot]){
                    swap(arr, j, i);
                    i++;
                }
            }
            swap(arr, pivot, i-1);
            return i-1;
        }

        public static void swap(int[] arr, int j, int i)
        {
            var temp= arr[i];
            arr[i]= arr[j];
            arr[j]= temp;
        }

        //Here we are choosing first element as pivot element
        // but we can choose any element as pivot element (such as medien of mediens)
        //which devides the array in atleast 30% - 70% ratio
        public static int choosePivotElement(int[] arr, int start, int end)
        {
            return start;
        }
    }
}