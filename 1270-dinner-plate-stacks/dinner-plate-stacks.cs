public class DinnerPlates {
    private List<Stack<int>> stacks;
    private int capacity;
    private SortedSet<int> availableStacks; // Tracks non-full stacks
    
    public DinnerPlates(int capacity) {
        this.stacks = new List<Stack<int>>();
        this.capacity = capacity;
        this.availableStacks = new SortedSet<int>();
    }
    
    public void Push(int val) {
        // If no available stacks, create a new one
        if (availableStacks.Count == 0) {
            stacks.Add(new Stack<int>());
            // If capacity is greater than 0, add this new stack to available stacks
            if (capacity > 0) {
                availableStacks.Add(stacks.Count - 1);
            }
        }
        
        // Get the leftmost available stack
        int index = availableStacks.Min;
        stacks[index].Push(val);
        
        // If stack becomes full, remove it from available stacks
        if (stacks[index].Count >= capacity) {
            availableStacks.Remove(index);
        }
    }
    
    public int Pop() {
        // If no stacks exist, return -1
        if (stacks.Count == 0) {
            return -1;
        }
        
        // Get the rightmost stack
        int lastIndex = stacks.Count - 1;
        
        // If the rightmost stack is empty, return -1
        if (stacks[lastIndex].Count == 0) {
            return -1;
        }
        
        // Pop value from the rightmost stack
        int val = stacks[lastIndex].Pop();
        
        // If stack was full but now has space, add to available stacks
        if (stacks[lastIndex].Count == capacity - 1) {
            availableStacks.Add(lastIndex);
        }
        
        // Remove empty stacks from the right end
        while (stacks.Count > 0 && stacks[stacks.Count - 1].Count == 0) {
            availableStacks.Remove(stacks.Count - 1);
            stacks.RemoveAt(stacks.Count - 1);
        }
        
        return val;
    }
    
    public int PopAtStack(int index) {
        // Check if index is valid and stack is not empty
        if (index < 0 || index >= stacks.Count || stacks[index].Count == 0) {
            return -1;
        }
        
        // Pop value from the specified stack
        int val = stacks[index].Pop();
        
        // If stack was full but now has space, add to available stacks
        if (stacks[index].Count == capacity - 1) {
            availableStacks.Add(index);
        }
        
        // Remove empty stacks from the right end only
        while (stacks.Count > 0 && stacks[stacks.Count - 1].Count == 0) {
            availableStacks.Remove(stacks.Count - 1);
            stacks.RemoveAt(stacks.Count - 1);
        }
        
        return val;
    }
}