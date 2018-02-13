/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class TwoSum
    {
        public int[] TwoSum_0(int[] nums, int target)
        {
            int tempX, tempY;
            int[] tempArr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    tempX = nums[i];
                    tempY = nums[j];

                    if (tempX + tempY == target)
                    {
                        tempArr[0] = i;
                        tempArr[1] = j;
                        return tempArr;
                    }
                }
            }
            return null;
        }

        //Solution用例:
        // Approach #1 (Brute Force) [Accepted]
        public int[] twoSum_1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }
        //1.暴力法,删除多余临时变量;
        //2.抛出异常来防止意外;


        // Approach #2 (Two-pass Hash Table) [Accepted]
        public int[] twoSum_2(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement) && dict[complement] != i)
                {
                    return new int[] { i, dict[complement] };
                }
                //if(dict.ContainsValue(complement))
                //{
                //    foreach(var temp in dict)
                //    {
                //        if(temp.Value == complement)
                //        {
                //            if(temp.Key != i)
                //            {
                //                return new int[] { i, temp.Key };
                //            }
                //        }
                //    }
                //}
            }
            throw new Exception("No two sum solution");
        }
        //1. 对数组建立图/字典/键值对;
        //2. 数组遍历一次,求得每个元素的补足数,判断是否存在于字典中,返回答案索引;
        //3. 示例中运用java的hashMap,添加键值对插入重复的Key时,之前的key的value会被覆盖.而c#dict不可插入重复key;
        //4. 解决方案1: 模仿hashMap初始化.构建dict时,进行判断,key重复则更新该key对应的value;
        //5. 解决方案2: 以数组索引为Key,元素值为value,判断存在value时,遍历dict获得指定key.不推荐;


        //Approach #3 (One-pass Hash Table) [Accepted]
        public int[] twoSum_3(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { i, dict[complement] };
                }
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new Exception("No two sum solution");
        }
        //在twoSum_2基础上,构建字典同时判断是否补足数已存在,存在直接返回,否则当前键值对添加进字典;
    }
}
