public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> roman=new();
        roman['I']=1; //V,X
        roman['V']=5;
        roman['X']=10; //L,C
        roman['L']=50;
        roman['C']=100; //D,M
        roman['D']=500;
        roman['M']=1000;


        
        //rule 1: XX + V + II=27, same char number
        //rule:2 IV=4, IX:9, XL:40, XC:90,CD: 400,CM:900

        //X:L,C
        int sum=0;
        for(int i=0;i<s.Length;i++)
        {
            if(i+1<s.Length&&roman[s[i]]<roman[s[i+1]])
            {
                  sum-=roman[s[i]];
                  continue;
               

            }
             sum+=roman[s[i]];
             
            
              
            
        }


        return sum;


        
    }
}