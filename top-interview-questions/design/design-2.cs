// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
// Implement the MinStack class:
//     MinStack() initializes the stack object.
//     void push(int val) pushes the element val onto the stack.
//     void pop() removes the element on the top of the stack.
//     int top() gets the top element of the stack.
//     int getMin() retrieves the minimum element in the stack.
// You must implement a solution with O(1) time complexity for each function.
public class MinStack {
    private List<int> stackList;
    
    public MinStack() {
        stackList = new List<int>();
    }
    
    public void Push(int val) {
        stackList.Add(val);
    }
    
    public void Pop() {
        stackList.RemoveAt(stackList.Count - 1);
    }
    
    public int Top() {
        if (stackList.Count <= 0) {
            return 0;
        }
        
        return stackList[stackList.Count - 1];
       
    }
    
    public int GetMin() {        
        if (stackList.Count <= 0) {
            return 0;
        }

        var min = stackList[0];

        foreach (var value in stackList) {
            if (value < min) {
                min = value;
            }
        }
        
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */