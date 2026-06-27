class Deque {

    public class Node
    {
        public int val;
        public Node next;
        public Node prev;

        public Node(int val)
        {
            this.val = val;
            next = null;
            prev = null;
        }
    }

    public Node head = new Node(0);
    public Node tail = new Node(0);

    public Deque() {
        head.next = tail;
        tail.prev = head;
    }

    public bool isEmpty() {
        return head.next == tail;    
    }

    public void append(int value) {
        Node newNode = new Node(value);
        tail.prev.next = newNode;
        newNode.next = tail;
        newNode.prev = tail.prev;
        tail.prev = newNode;
    }

    public void appendleft(int value) {
        Node newNode = new Node(value);
        
        newNode.next = head.next;
        newNode.prev = head;

        head.next.prev = newNode;
        head.next = newNode;
    }

    public int pop() {
        if (isEmpty()) return -1;
        Node toRemove = tail.prev;
        
        toRemove.prev.next = tail;
        tail.prev = toRemove.prev;

        toRemove.next = null;
        toRemove.prev = null;
        return toRemove.val;
    }

    public int popleft() {
        if (isEmpty()) return -1;
        Node toRemove = head.next;
        
        head.next = toRemove.next;
        toRemove.next.prev = head;

        toRemove.next = null;
        toRemove.prev = null;
        return toRemove.val;
    }
}
