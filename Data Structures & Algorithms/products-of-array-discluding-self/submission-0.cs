public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int>res = new List<int>();
        for(int i=0;i<nums.Length;i++)
        {
            int prod=1;
            for(int j=0;j<nums.Length;j++)
            {
                if(j!=i)
                {
                    prod*=nums[j];
                }
            }
            res.Add(prod);
        }
        return res.ToArray();
    }
}
