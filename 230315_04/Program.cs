
//Bad O(n^2) method (nested for loop)
int[] TwoSum(int[] nums, int target) 
{
    for (int i = 0; i < nums.Count(); i++)
    {
        for (int j = 0; j < nums.Count(); j++)
        {
            if (nums[i] + nums[j] == target)
            {
                if(i == j)
                {
                    continue;
                }
                else
                {
                    return new int[] { i, j };
                }
            }
        }
    }
    return new int[2];
}

// int[] test1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
// int[] test2 = TwoSum(new int[] { 3,2,4 }, 6);
// int[] test3 = TwoSum(new int[] { 3,3 }, 6);

// foreach(int i in test2)
// {
//     Console.WriteLine(i);
// }

int[] TwoSumTwo(int[] nums, int target) {
    Dictionary<int, int> map = new Dictionary<int, int>();
    int[] result = new int[2];
    for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (map.ContainsKey(complement)) {
            return new int[] { map[complement], i };
        }
        map[nums[i]] = i;
    }
    throw new Exception("No two sum solution");
}


int[] test1 = TwoSumTwo(new int[] { 2, 7, 11, 15 }, 9);
int[] test2 = TwoSumTwo(new int[] { 3,2,4 }, 6);
int[] test3 = TwoSumTwo(new int[] { 3,3 }, 6);

foreach(int i in test2)
{
    Console.WriteLine(i);
}