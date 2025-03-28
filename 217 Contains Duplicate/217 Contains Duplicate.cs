class Solution {
    public boolean containsDuplicate(int[] nums) {
        
	for (int index = 0; index < nums.Length; index++)
	{
		if (hs.Contains(nums[index]))
		{
			return true;
		}
		hs.Add(nums[index]);
	}
	return false;
    }
}

//LINQOPAD 8

//void Main()
//{
//	bool magicalBool = ContainsDuplicate([1, 2, 3, 4]);
//	System.Console.WriteLine(magicalBool);
//	
//}
//
//public bool ContainsDuplicate(int[] nums)
//{
//	HashSet<int> hs = new HashSet<int>();
//	
//	for (int index = 0; index < nums.Length; index++)
//	{
//		if (hs.Contains(nums[index]))
//		{
//			return true;
//		}
//		hs.Add(nums[index]);
//	}
//	return false;
//}
