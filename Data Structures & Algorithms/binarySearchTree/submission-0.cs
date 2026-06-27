class TreeMap {

    public class TreeNode 
    {
        public int key;
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int key,int val)
        {
            this.key = key;
            this.val = val;
        }
    }

    public TreeNode root;
    public TreeMap() {
        root = null;
    }

    public void Insert(int key, int val) {
        TreeNode node = new TreeNode(key,val);
        
        if(root==null)
        {
            root = node;
            return;
        }

        TreeNode curr = root;
        while(true)
        {
            if(curr.key>key)
            {
                if(curr.left==null)
                {
                    curr.left = node;
                    return;
                }
                curr = curr.left;
            }
            else if(curr.key<key)
            {
                if(curr.right==null)
                {
                    curr.right = node;
                    return;
                }
                curr = curr.right;
            }
            else
            {
                curr.val = val;
                return;
            }
        }
    }

    public int Get(int key) {
        TreeNode curr = root;
        while(curr!=null)
        {
            if(curr.key<key)
            {
                curr = curr.right;
            }
            else if(curr.key>key)
            {
                curr = curr.left;
            }
            else
            {
                return curr.val;
            }
        }
        return -1;
    }

    public int GetMin() {
        TreeNode curr = root;
        while(curr!=null)
        {
            if(curr.left==null)
            {
                return curr.val;
            }
            else
            {
                curr = curr.left;
            }
        }
        return -1;
    }

    TreeNode FindMin(TreeNode node)
    {
        TreeNode curr = node;
        while(curr!=null)
        {
            if(curr.left==null)
            {
                return curr;
            }
            else
            {
                curr = curr.left;
            }
        }
        return null;
    }

    public int GetMax() {
        TreeNode curr = root;
        while(curr!=null)
        {
            if(curr.right==null)
            {
                return curr.val;
            }
            else
            {
                curr = curr.right;
            }
        }
        return -1;
    }

    public void Remove(int key) {
        root = RemoveHelp(root,key);
    }

    TreeNode RemoveHelp(TreeNode curr,int key)
    {
        if(curr==null)
        {
            return null;
        }
        if(curr.key>key)
        {
            curr.left = RemoveHelp(curr.left,key);
        }
        else if(curr.key<key)
        {
            curr.right = RemoveHelp(curr.right,key);
        }
        else
        {
            if(curr.right==null)
            {
                return curr.left;
            }
            else if(curr.left == null)
            {
                return curr.right;
            }
            else
            {
                TreeNode min = FindMin(curr.right);
                curr.val = min.val;
                curr.key = min.key;
                curr.right = RemoveHelp(curr.right,curr.key);
            }
        }
        return curr;
    }

    public List<int> GetInorderKeys() {
        List<int> list = new List<int>();
        dfs(root,list);
        return list;
    }

    void dfs(TreeNode node,List<int> list)
    {
        if(node==null)
        {
            return;
        }
        dfs(node.left,list);
        list.Add(node.key);
        dfs(node.right,list);
    }

    

}
