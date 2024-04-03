public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if(value == Data){
        
        } else {
            if (value < Data) {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data){
            return true;
        } else {
           if(Left != null && Left.Contains(value)){
            return true;
           }
           if(Right != null && Right.Contains(value)){
            return true;
           }
    
        return false;
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (this == null){
            return 0;
        } else {
            int leftHeight = 0;
            int rightHeight = 0;

            if(Left != null){
                 leftHeight = Left.GetHeight();
            }

            if (Right != null){
                rightHeight = Right.GetHeight();
            }

            return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
        }
    }
}