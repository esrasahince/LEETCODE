public class NumArray {
    int[] tree=null;
    int[] nums=null;

    public NumArray(int[] nums) {
        this.tree=new int[nums.Length*4];
        this.nums=nums;
        BuildTree(nums,tree,0,nums.Length-1,0);
        
    }
    public void BuildTree(int[] nums,int[] tree, int left,int right,int index)
    {
        if(left==right) //leaf node
        {
            tree[index]=nums[left];
            return;
        }
        int middle=(left+right)/2;
        int leftind=2*index+1;
        int rightind=2*index+2;
        //left-middle, middle+1-right olmak üzere iki segment

        BuildTree(nums,tree,left,middle,leftind);
        BuildTree(nums,tree,middle+1,right,rightind);
        tree[index]=tree[leftind]+tree[rightind];
    }
    
    public void Update(int index, int val) {
        nums[index]=val;
        UpdateTree(0,0,nums.Length-1,index,val);
        
    }
    public void UpdateTree(int index,int left,int right,int updateindex,int val)
    {
        if(left==right)
        {
        tree[index]=val;
        return;
        
        }
        int middle=(left+right)/2;
       if(updateindex<=middle)
       {
        UpdateTree(2*index+1,left,middle,updateindex,val);
       }
       else
       {
        UpdateTree(2*index+2,middle+1,right,updateindex,val);
       }
       tree[index]=tree[2*index+1]+tree[2*index+2];
    }
    
    public int SumRange(int left, int right) {

        //3 tane durum var
        return Sum(0,0,nums.Length-1,left,right);
        
    }
    public int Sum(int index,int nl,int nr,int ql,int qr)
    {
        if(qr<nl||nr<ql)
        {
            //no overlap
            return 0;
        }
        if(ql<=nl&&qr>=nr)
        {
            //fully overlap
            return tree[index];
        }
        else
        {
            int middle=(nl+nr)/2;
            int leftind=2*index+1;
            int rightind=2*index+2;
            int leftsum=Sum(leftind,nl,middle,ql,qr);
            int rightsum=Sum(rightind,middle+1,nr,ql,qr);
            return leftsum+rightsum;
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */