using System;

namespace RandomizeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr= {5,2,1,6,3,4,9,8,7,10};
           var ThirdHighestNumber= new NthOrderStatistics().FindNthHighestElement(arr,3);
           var FifthHighestNumber= new NthOrderStatistics().FindNthHighestElement(arr,5);
           var sortedArr= new QuickSort().Sort(arr);
        }
    }
}
