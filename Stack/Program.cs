Stack<int> stack = new(3);

stack.Push(0);
stack.Push(1);
stack.Push(2);

stack.Pop();
stack.Pop();
stack.Pop();

public class Stack<T>
{
    public int top { get; private set; }
    public T[] stack { get; private set; }

    private int size;
    public Stack(int size)
    {
        this.size = size;
        stack = new T[size];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top < 0;
    }

    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow.");
            return default(T);
        }

        return stack[top--];
    }

    public bool Push(T value)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow.");
            return false;
        }

        stack[++top] = value;
        return true;
    }
}