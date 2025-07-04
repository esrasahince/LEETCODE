public class Solution {
    public string NextClosestTime(string time) {

        int[] arr=new int[4];
        int count=0;
        int min=9;
        foreach(char c in time)
        {
            if(Char.IsDigit(c))
            {
                arr[count]=c-'0';
                min=Math.Min(arr[count],min);
                count++;
            }
            
        }
       int[] order=arr.Distinct().OrderBy(x => x).ToArray();
       Dictionary<int,int> dict=new();
       for(int i=0;i<order.Length-1;i++)
       {
       
        dict[order[i]]=order[i+1];
       
       }
       dict[order[order.Length-1]]=-1;

       int left=3;
       while(left>=0)
       {
        if(dict[arr[left]]!=-1)
        { 
            int temp=arr[left];
            arr[left]=dict[arr[left]];
            if(Check(arr))
            {
                for(int i=left+1;i<4;i++)
                {
                    arr[i]=min;
                }
                return ConvertString(arr);
            }
         
            else
            {
            arr[left]=temp;
            left--;
            }
          
        }
        else{left--;}

       }
       Array.Fill(arr,min);
       return ConvertString(arr);
       
    }
    public string ConvertString(int[] arr)
    {
        StringBuilder str=new();
        for(int i=0;i<4;i++)
        {
        str.Append((char)(arr[i] + '0'));
            if(i==1)
            str.Append(":");
        }
        return str.ToString();
    }
    public bool Check(int[] arr)
    {
        if(arr[0]*10+arr[1]>=24||arr[2]*10+arr[3]>=60)
        return false;
     
        return true;
    }

}