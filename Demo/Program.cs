using System.Collections;
using System.ComponentModel;
using System.Globalization;
//using System.Collections.Generic;  always in global Namespaces (in the far left of line 1)
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collections [Array List]
            ///ArrayList nums = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///if (nums.Capacity < 21)
            ///    nums.Capacity = 21;
            ///for (int i = 6; i<=21;  i++)
            ///{
            ///    nums.Add(i);
            ///}
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");

            ///Adding and Trimming
            ///nums.Add(1);
            ///nums.Add(2);
            ///nums.AddRange(new int[] { 3, 4 });
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.Add(5);
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            ///nums.TrimToSize();
            ///Console.WriteLine("After Trimming");
            ///Console.WriteLine($"Count = {nums.Count}, Capacity = {nums.Capacity}");
            #endregion
        }
    }
}
