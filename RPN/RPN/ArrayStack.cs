using System;
using RPN;

public class ArrayStack<T> : IStack<T>
{
    private T[] stack;
    private int top;
    private int capacity;

    public ArrayStack(int capacity)
    {
        this.capacity = capacity;
        stack = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == capacity - 1)
        {
            throw new InvalidOperationException("Stack overflow: Cannot push onto a full stack.");
        }
        stack[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack underflow: Cannot pop from an empty stack.");
        }
        return stack[top--];
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty: Cannot peek.");
        }
        return stack[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
