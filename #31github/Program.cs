#region TwoSum
int[] result = TwoSum(new int[] { 2, 5, 5, 11 }, 10);

foreach (int i in result)
{
    Console.WriteLine(i);
}

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = 0; j < nums.Length - 1; j++)
        {
            if (nums[i] + nums[j + 1] == target && i != j + 1)
            {
                return new int[] { i, j + 1 };
            }
        }
    }
    return null;
}
#endregion