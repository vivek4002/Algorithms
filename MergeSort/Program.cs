using System;

namespace MergeSort {
    class Program {
        static void Main (string[] args) {
            int[] arr = { 5, 2, 1, 6, 3, 4, 9, 8, 7, 10 };
            var sorted = new MergeSort ().Sort (arr);
        }
    }
}