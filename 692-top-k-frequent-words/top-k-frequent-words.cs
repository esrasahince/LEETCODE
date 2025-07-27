public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
      Dictionary<string,int> dict=new();
      foreach(string s in words)
      {
        dict[s]=dict.ContainsKey(s)?dict[s]+1:1;
      }

      //Burada öncelik frekans daha sonra ise string alfabetik sırasına göre sıralama yapılması isteniyor
      //bu nedenle comparer nesnesinin tipi bir tuple
      Comparer<(string item,int frekans)> comp=Comparer<(string item,int frekans)>.Create((a,b)=>{
      int firstpriority=b.frekans.CompareTo(a.frekans);
      if(firstpriority!=0) return firstpriority;
      int secondpriority=a.item.CompareTo(b.item);
      return secondpriority;
      });
      PriorityQueue<string,(string,int)> que=new(comp);
      
      foreach(var item in dict)
      {
        que.Enqueue(item.Key,(item.Key,item.Value));
      } 
      List<string> result=new();
      while(k>0)
      {
        result.Add(que.Dequeue());

        k--;
      } 
      
      return result;     
    }
}