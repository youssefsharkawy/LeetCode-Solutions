﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
           
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                    
                }
                
                
            }
            return nums;
        }
    }
}
