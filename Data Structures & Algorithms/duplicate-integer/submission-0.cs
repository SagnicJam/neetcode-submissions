public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>numHash = new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(numHash.Contains(nums[i]))
            {
               return true;
            }
            else
            {
                numHash.Add(nums[i]);
            }
        }
        return false;
    }
}
