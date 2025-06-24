public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {

      int left=0;
      int right=arr.Length-1;
      int ind=0;
      bool found = false;
      while(left+1<right)
      {
        int middle=left+(right-left)/2;
        if(arr[middle]==x)
        {
        ind=middle;
          found = true;
        break;
        }
        else if(arr[middle]<x)
        left=middle;
        else
        right=middle;

      }
      if(!found)
      {
if (arr[left] <= x && Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x))
    ind = left;
else
    ind = right;
      }

      
      List<int> result=new();
      result.Add(arr[ind]);
      int leftptr=ind-1;
      int rightptr=ind+1;
      while(leftptr>=0&&rightptr<arr.Length)
      {
        if(Math.Abs(arr[leftptr]-x)<Math.Abs(arr[rightptr]-x)&&result.Count<k)
       { result.Add(arr[leftptr]);
        leftptr--;
       } else if (Math.Abs(arr[leftptr]-x)==Math.Abs(arr[rightptr]-x)&&result.Count<k&&arr[leftptr]<arr[rightptr])
       {
        result.Add(arr[leftptr]);
        leftptr--;

       }
       
      else if(result.Count<k)
       {
        result.Add(arr[rightptr]);
        rightptr++;
       }
       if(result.Count==k)
       break;
        
      }
      while(result.Count<k&&leftptr>=0)
      {
        result.Add(arr[leftptr]);
        leftptr--;
      }
      while(result.Count<k&&rightptr<arr.Length)
      {
        result.Add(arr[rightptr]);
        rightptr++;
      }
     result.Sort();
     return result;
    }
}