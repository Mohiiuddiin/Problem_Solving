using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            var i = TwoSum(nums, 9);
            Console.WriteLine(i);
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    return new int[] { dictionary[nums[i]], i };
                }                    
                else
                {
                    dictionary[target - nums[i]] = i;//adding key for value
                }
                
            }

            //var num = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    var n = new int[] { };
            //    if (num>0)
            //    {
            //        return new int[] { num, i };
            //    }
            //    else
            //    {

            //    }
            //}

            return new int[] { };
        }
    }
}
