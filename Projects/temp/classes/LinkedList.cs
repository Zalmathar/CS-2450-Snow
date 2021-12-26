namespace classes.LinkedList;

public class LinkedList<T>
{
    private Node<T>? head;
    public int count;

    public LinkedList()
    {
        head = null;
        count = 0;
    }

    /// <summary> 
    /// Adds the value to the end of the linked list
    /// </summary>
    public void Add(T value)
    {
        if (head == null)
        {
            head = new Node<T>(value, null);
        }
        else
        {
            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node<T>(value, null);
        }
        count++;
    }

    /// <summary>
    /// Inserts the value to the specified index of the list.
    /// If the index is greater than the current count of the list the node is added to the end of this list.
    /// </summary>
    public void Add(int index, T value)
    {
        if (head == null)
        {
            Add(value);
        }
        else
        {
            Node<T> current = head;
            Node<T>? prev = null;
            for (int i = 0; i < index; i++)
            {
                if (current.next != null)
                {
                    prev = current;
                    current = current.next;
                }
                else
                {
                    current.next = new Node<T>(value, null);
                }
            }

            if(prev != null)
            {
                Node<T> newNode = new Node<T>(value, current);
                prev.next = newNode;
            }
        }
    }

    /// <summary>
    /// Returns the value of the First index of the list
    /// </summary>
    public T Peek()
    {
        if (head != null)
        {
            return head.value;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    /// <summary>
    /// Returns the value at index without removing it
    /// </summary>
    public T Peek(int index)
    {
        if (index > count || head == null)
        {
            throw new IndexOutOfRangeException();
        }

        Node<T> current = head;
        for (int i = 0; i < index; i++)
        {
            if (current.next != null)
                current = current.next;
            else 
                throw new IndexOutOfRangeException();
        }
        return current.value;
    }

    /// <summary>
    /// Retrieves and Removes the head (first node) of this list.
    /// </summary>
    public T Remove()
    {
        if (head != null)
        {
            Node<T> current = head;
            head = current.next;
            return current.value;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    /// <summary>
    /// Returns the value of the node at index and Removes it from the list
    /// </summary>
    public T Remove(int index)
    {
        if (index > count || index < 0 || this.head == null)
        {
            throw new IndexOutOfRangeException();
        }

        Node<T>? current = this.head;
        Node<T>? prev = null;
        for (int i = 0; i < index; i++)
        {
            if (current.next != null)
            {
                prev = current;
                current = current.next;
            }
            else 
            {
                throw new IndexOutOfRangeException();
            }
        }
        if(prev != null)
        {
            prev.next = current.next;
            count--;
        }
        else if(current == head)
        {
            head = current.next;
            count--;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
        return current.value;
    }
}

public class Node<T>
{
    public T value {get; set;}
    public Node<T>? next {get; set;}

    public Node(T value, Node<T>? nextNode)
    {
        if(value == null)
        {
            throw new NullReferenceException();
        }
        this.value = value;
        this.next = nextNode;
    }
}