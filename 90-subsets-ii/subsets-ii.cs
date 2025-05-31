public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> result=new();
        Array.Sort(nums);
        List<int> temp=new();
        Backtracking(nums,0,temp,result);
        return result;
    }
     public void Backtracking(int[] nums,int index,List<int> temp,List<IList<int>> result)
    {
        if(index>=nums.Length)
        {
            result.Add(new List<int>(temp));
            return;
        }
        //ekle
            temp.Add(nums[index]);
            Backtracking(nums,index+1,temp,result);
            temp.RemoveAt(temp.Count-1);
        //ekleme 
        //Dublicate burada sıkıntı oluyor. 
        //Eğer eklemediysen ve bir sonraki elemanda aynı ise o elemanı atla.
          while(index+1<nums.Length&&nums[index]==nums[index+1])
          {
          index++;
          }
          Backtracking(nums,index+1,temp,result);



        }
        
    }
        
    
    
