using System;

namespace RandomizeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr= {5,2,1,6,3,4,9,8,7,7,6,4,10};
           var sortedArr= new QuickSort().Sort(arr);
        }
    }
}
