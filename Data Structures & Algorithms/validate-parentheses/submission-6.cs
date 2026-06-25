public class Solution {
    public bool IsValid(string s) {
        //use a dictionary to map them first
        //use a stack to pop them now

        char[] charArr = s.ToCharArray();

        Dictionary<char,char>charDic = new Dictionary<char,char>();
        charDic.Add(')','(');
        charDic.Add('}','{');
        charDic.Add(']','[');
        

        Stack<char>charStack = new Stack<char>();
        for(int i=0;i<charArr.Length;i++)
        {
            if(charDic.ContainsKey(charArr[i])&&charStack.Count>0&&charDic[charArr[i]]== charStack.Peek())
            {
                charStack.Pop();
            }
            else
            {
                charStack.Push(charArr[i]);
            }
        }

        return charStack.Count==0;
    }
}
