public class LRUCache {
    private Dictionary<int, CacheNode> cacheMap;
    public CacheNode head = new();
    public CacheNode tail = new();
    private int cacheCapacity;
    
    public LRUCache(int capacity) {
        cacheCapacity = capacity;
        cacheMap = new(cacheCapacity);
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        int result = -1;
        
        if (cacheMap.ContainsKey(key)) {
            CacheNode node = cacheMap[key];
        
            if (node is not null) {
                result = node.val;
            
                MakeItemRecentlyUsed(node);
            }    
        }
        
        return result;
    }
    
    public void Put(int key, int value) {
        if (cacheMap.ContainsKey(key)) {
            CacheNode node = cacheMap[key];
            
            if (node is not null) {
                Remove(node);
            
                node.val = value;
            
                Add(node);
            }
        } else {
            if (cacheMap.Count == cacheCapacity) {
                cacheMap.Remove(tail.prev.key);
                Remove(tail.prev);    
            }
                
            CacheNode newNode = new();
            newNode.key = key;
            newNode.val = value;
                
            cacheMap.Add(key, newNode);
            Add(newNode);
        }
    }
    
    public void Add(CacheNode node) {
        CacheNode newHead = head.next;
        node.next = newHead;
        newHead.prev = node;
        head.next = node;
        node.prev = head;
    }
    
    public void Remove(CacheNode node) {
        CacheNode prevNode = node.prev;
        CacheNode nextNode = node.next;
        
        prevNode.next = nextNode;
        nextNode.prev = prevNode;
    }
    
    public void MakeItemRecentlyUsed(CacheNode node) {
        Remove(node);
        Add(node);
    }
    
    public class CacheNode {
        public int key;
        public int val;
        public CacheNode next;
        public CacheNode prev;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */