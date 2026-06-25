public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!=t.Length)
        {
            return false;
        }
        Dictionary<char,int>sDic = GetFreqDic(s);
        Dictionary<char,int>tDic = GetFreqDic(t);


        foreach(KeyValuePair<char,int>kvp in sDic)
        {
            if(tDic.ContainsKey(kvp.Key)&&
            tDic[kvp.Key] == kvp.Value)
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    Dictionary<char,int>GetFreqDic(string s)
    {
        Dictionary<char,int>dic = new Dictionary<char,int>();
        char[] charArr = s.ToArray();
        for(int i=0;i<charArr.Length;i++)
        {
            if(dic.ContainsKey(charArr[i]))
            {
                dic[charArr[i]]++;
            }
            else
            {
                dic.Add(charArr[i],1);
            }
        }
        return dic;
    }
}
