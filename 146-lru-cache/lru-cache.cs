public class LRUCache {
    LinkedList<(int,int)> list=null;
    Dictionary<int,LinkedListNode<(int,int)>> dict=null;
    int capacity=0;

    public LRUCache(int capacity) {
        this.capacity=capacity;
        this.dict=new();
        this.list=new();
        
    }
    
    public int Get(int key) {
        if(dict.ContainsKey(key))
        {
            var item=dict[key];
            (int itemkey,int itemvalue)=item.Value;
            list.Remove(item);
            list.AddFirst((key,itemvalue));
            dict[key]=list.First;
            return itemvalue;

        }
        else
        {
            return -1;
        }
        
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key))
        {
            var item=dict[key];
            list.Remove(item);
            list.AddFirst((key,value));
            dict[key]=list.First;
          

        }
        else
        {
            if(dict.Count==capacity)
            {
             (int last,int lastvalue)=list.Last.Value;
             dict.Remove(last);
             list.RemoveLast();

            }
            list.AddFirst((key,value));
            dict[key]=list.First;
        }
        
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */