public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[]res = new int[nums.Length];

        int product = 1;
        int zeroCount=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
            {
                product *= nums[i]; 
            }
            else{
                zeroCount++;
            }
        }

        for(int i=0;i<nums.Length;i++)
        {
            if(zeroCount>0)
            {
                if(nums[i]!=0)
                {
                    nums[i] = 0;
                }
                else
                {
                    if(zeroCount>1)
                    {
                        res[i]=0;
                    }
                    else
                    {
                        res[i] = product;
                    }
                }
            }else{
                 res[i] = product/nums[i];
            }
        }

        return res;
    }
}
