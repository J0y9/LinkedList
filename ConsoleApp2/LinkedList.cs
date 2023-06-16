namespace ConsoleApp2;

public class Node
{
    public  string Data { get; set; }
    public Node? Next { get; set; }
}
public  class LinkedList
{
    public Node Head { get; set; }
    public void AddFirst(string data)
    {
        var newNode = new Node();

        newNode.Data = data;
        newNode.Next = Head;
        Head = newNode;
    }

    public void AddLast(string data)
    {
        if (Head == null)
        {
            Head = new Node();
            Head.Data = data;
            Head.Next = null;

        }
        else
        {
            var newNode = new Node();
            newNode.Data = data;

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }
    public void PrintLinkedList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public string GetIndex(string data)
    {
        if (Head == null)
        {
            return "Empty Linked List";
        }

        var index = 0;
        Node current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return $"index of {data} is {index}";
                    
            }
            current = current.Next;
            index++;
        }

        return "No Node exist with this data";
    }
    public string IsExist(string data)
    {
        if (Head == null)
        {
            return "Empty Linked List";
        }


        Node current = Head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return "element is exist";

            }
            current = current.Next;

        }

        return "No Node exist with this data";
    }

}
