using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sumChecker = TwoSum(new[] {2, 7, 11, 15}, 9);
            foreach (var item in sumChecker)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int sum = 0;
            int[] indices =new int[2];
            for (int i = 0; i <= nums.Length-1; i++)
            {
                for (int j = 0; j<=nums.Length-1 ; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        indices[0] = nums[i];
                        indices[1] = nums[j];
                        break;
                    }
                }
            }

            return indices;
        }
    }
}