public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> result=new();
        List<int> temp=new();

        Backtracking(n,k,1,temp,result);
        return result;
        
    }
    public void Backtracking(int n,int k,int index,List<int> temp,List<IList<int>> result)
    {
        if(temp.Count==k)
        {
            result.Add(new List<int>(temp));
            return;
        }
        if(index>n)
        return;
      
                Backtracking(n,k,index+1,temp,result);

                temp.Add(index);
                Backtracking(n,k,index+1,temp,result);
                temp.RemoveAt(temp.Count-1);
              
            
        
    }
}