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

            if (arr.Length==1) return arr;
            //Devide
            var partition= Partition(arr);
            //Conquor
            var sortedArr1=Sort (partition.arr1);
            var sortedArr2= Sort (partition.arr2);
            //Merge
            return Merge (sortedArr1,sortedArr2 );

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

        private (int[] arr1, int[] arr2) Partition (int[] arr) {
            var partitionIndex = arr.Length / 2;
            var arr1 = new int[partitionIndex];
            var arr2 = new int[arr.Length - partitionIndex];
            int i = 0;
            while (i < partitionIndex) {
                arr1[i] = arr[i];
                i++;
            }
            while (i < arr.Length) {
                arr2[i-partitionIndex] = arr[i];
                i++;
            }
            return (arr1, arr2);
        }
    }
}