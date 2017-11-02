using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class PokemonDontGo
{
    static void Main()
    {
        List<int> nums = Regex.Split(Console.ReadLine(), @"\s+").Where(x => x != String.Empty).Select(int.Parse).ToList();

        int removed = 0;
        int endResult = 0;

        while (nums.Count > 0)
        { 
            int index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                removed = nums[0];
                nums[0] = nums[nums.Count - 1];

                nums = IncreaseAndDecrease(nums, removed);

                endResult += removed;
            }
            else if (index > nums.Count - 1)
            {
                removed = nums[nums.Count - 1];
                nums[nums.Count - 1] = nums[0];

                nums = IncreaseAndDecrease(nums, removed);
                                      
                endResult += removed;
            }
            else
            {
                removed = nums[index];
                nums.RemoveAt(index);

                nums = IncreaseAndDecrease(nums, removed);

                endResult += removed;
            }
        }

        Console.WriteLine(endResult);
    }

    private static List<int> IncreaseAndDecrease(List<int> nums, int removed)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] <= removed) 
            {
                nums[i] += removed;
            }
            else
            {
                nums[i] -= removed;
            }
        }

        return nums;
    }
}
