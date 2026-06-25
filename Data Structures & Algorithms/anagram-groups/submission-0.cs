public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //make an array of size 26
        //store the frequency of the characters in an array
        //main crux of the problem is this
        //we know that the frequency of two words should match
        //so we create a key for each str and compare those keys in order to add them in the list

        Dictionary<string,List<string>>anagramDic = new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++)
        {
            int[] key = new int[26];
            char[] charArr = strs[i].ToCharArray();
            for(int j=0;j<charArr.Length;j++)
            {
                key[charArr[j]-'a']+=1;
                //this will build a key int[] we can convert it into a string by using some rule
            }

            string uniqueKey = string.Join(",",key);
            
            //we can make a hasmap with the unique key being the key which is used to get the values
            if(anagramDic.ContainsKey(uniqueKey))
            {
                anagramDic[uniqueKey].Add(strs[i]);
            }
            else
            {
                anagramDic.Add(uniqueKey,new List<string>(){strs[i]});
            }
        }

        List<List<string>>res = new List<List<string>>();
        foreach(KeyValuePair<string,List<string>>kvp in anagramDic)
        {
            res.Add(kvp.Value);
        }

        return res;
    }
}
