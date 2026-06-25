public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int>hashMap = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            int difference = target-nums[i];
            if(hashMap.ContainsKey(difference))
            {
                return new int[2]{hashMap[difference],i};
            }
            else
            {
                hashMap.Add(nums[i],i);
            }
        }
        return new int[2];
    }
}
