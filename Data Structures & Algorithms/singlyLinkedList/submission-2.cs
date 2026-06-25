public class LinkedList {

    public class Node
    {
        public int val;
        public Node next;

        public Node(int val)
        {
            this.val = val;
            next = null;
        }
    }

    public Node head;
    public Node tail;
    public LinkedList() {
        head = new Node(-1);
        tail = head;
    }

    public int Get(int index) {
        Node curr = head.next;
        int temp=0;
        while(curr!=null)
        {
            if(temp==index)
            {
                return curr.val;
            }
            temp++;
            curr = curr.next;
        }
        return -1;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head.next;
        head.next = newNode;

        if(newNode.next==null)
        {
            tail = newNode;
        }
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);
        tail.next = newNode;
        tail = newNode;
    }

    public bool Remove(int index) {
        Node curr = head.next;
        Node currPrev = head;
        int temp=0;
        while(curr!=null)
        {
            if(temp==index)
            {
                break;
            }
            temp++;
            curr = curr.next;
            currPrev = currPrev.next;
        }
        
        if(curr==null)
        {
            return false;
        }
        else
        {
            if(curr==tail)
            {
                tail = currPrev;
            }
            currPrev.next = curr.next;
            curr.next = null;
            return true;
        }
    }

    public List<int> GetValues() {
        List<int> res = new List<int>();
        Node curr = head.next;
        while(curr!=null)
        {
            res.Add(curr.val);
            curr = curr.next;
        }
        return res;
    }
}