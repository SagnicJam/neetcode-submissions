public class DynamicArray {
    
    int capacity;
    int length;
    int[] arr;
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        arr = new int[capacity];
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
       if(length==capacity)
       {
            Resize();
       }
       arr[length++] = n;
    }

    public int PopBack() {
        if(length>0)
        {
            length--;
        }   
        return arr[length];
    }

    private void Resize() {
        capacity = 2*capacity;
        int[] newArr = new int[capacity];
        for(int i=0;i<arr.Length;i++)
        {
            newArr[i] = arr[i];
        }
        arr = newArr;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}
