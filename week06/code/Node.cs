using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true;
        }
        else if (Left is not null && Left.Contains(value))
        {
            return true;
        }
        else if (Right is not null && Right.Contains(value))
        {
            return true;
        }
        return false;
    }

    public int GetHeight()
    {
        int leftNumber = 0;
        int rightNumber = 0;
        // TODO Start Problem 4
        if (Left == null && Right == null)
        {
            return 1;
        }
        if (Left is not null)
        {
            leftNumber = Left.GetHeight();
        }
        if (Right is not null)
        {
            rightNumber = Right.GetHeight();
        }

        int total = 1 + Math.Max(leftNumber, rightNumber);

        return total; // Replace this line with the correct return statement(s)
    }
}