using System;
namespace MergeSort {
    /* 
    Devide and Conquour Sort Technique
    Time Complexity: O(nlog(n))
    Not inplace sort- Requires N extra auxilary space
    */
    public class MergeSort {
        public int[] Sort (int[] arr) 
        {
            return Sort(arr,0,arr.Length-1);
        }

        public int[] Sort(int[] arr, int start, int end)
        {
            //base condition
            if(start==end) return new int[]{arr[start]};
            //Devide
            var partition= (start+end)/2;
            //Conquor  
            var firstSorted= Sort(arr, start,partition);
            var secondSorted=Sort(arr, partition+1, end);
            //Merge
            return Merge (firstSorted,secondSorted );

        }

        //Linear complexity
        public int[] Merge (int[] arr1, int[] arr2) 
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length) {
                if (arr1[i] < arr2[j]) {
                    arr[k] = arr1[i];
                    i++;
                } else {
                    arr[k] = arr2[j];
                    j++;
                }
                k++;
            }
            //copy rest of the elements
            while (i < arr1.Length) {
                arr[k] = arr1[i];
                i++;
                k++;
            }
            while (j < arr2.Length) {
                arr[k] = arr2[j];
                j++;
                k++;
            }
            return arr;

        }

    }
}