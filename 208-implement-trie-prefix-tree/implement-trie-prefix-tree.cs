public class Node
{
    public Dictionary<char,Node> children;
    public bool last{get;set;}
    public Node()
    {
        this.children=new();
        this.last=false;
        

    }
}

public class Trie {
    Node root;
    public Trie() {
        
    this.root=new Node();
        
    }
    
    public void Insert(string word) {
        Node current=root;
        for(int i=0;i<word.Length;i++)
        {
            if(!current.children.ContainsKey(word[i]))
            {
                current.children[word[i]]=new Node();
            }
         
            current=current.children[word[i]];
        }
        current.last=true;
       

    }
    
    public bool Search(string word) {

        Node current=root;
        foreach(char c in word)
        {
            if(current.children.ContainsKey(c))
            {
                current=current.children[c];
            }
            else
            {
                return false;
            }
        }
        return current.last;
        
    }
    
    public bool StartsWith(string prefix) {


        Node current=root;
        foreach(char c in prefix)
        {
            if(!current.children.ContainsKey(c))
            {
                return false;
            }
          current=current.children[c];
        }
        return true;
        
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */