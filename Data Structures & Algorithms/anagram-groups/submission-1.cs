public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>>dic = new Dictionary<string,List<string>>();
        foreach(string s in strs)
        {
            char[] charArr = new char[26];
            foreach(char c in s)
            {
                charArr[c-'a']++;
            }
            string id = new string(charArr);
            if(dic.ContainsKey(id)==false)
            {
                dic[id] = new List<string>();
            }
            dic[id].Add(s);
        }

        List<List<string>>res = new List<List<string>>();
        foreach(KeyValuePair<string,List<string>>kvp in dic)
        {
            res.Add(kvp.Value);
        }
        return res;
    }
}
