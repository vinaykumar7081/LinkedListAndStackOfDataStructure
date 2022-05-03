using System;
using StackAndQueueOfDataStructure;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** WELCOME IN STACK AND QUEUE OPERATIONS ***** ");
    StackAndQueue stack=new StackAndQueue();
        Console.WriteLine(" Display Stack Elements 1\n Peek And Pop Operation 2\n Deleting Top of the Elements Of Stack 3\n Checking Stack is Empty 4\n Display Queue Elements 5\n Delete Elements From Queues 6\n");
        bool check = true;
        while (check)
        { 
        Console.WriteLine(" ####### Enter the Above Option To Perform the Operation #######");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                    case 2:
                    stack.Peek();
                    break;
                case 3:
                    stack.Pop();
                    break;
                case 4:
                    stack.IsEmpty();
                    break;
                case 5:
                    stack.Enqueue(70);
                    stack.Enqueue(30);
                    stack.Enqueue(56);
                    break;
                case 6:
                    stack.Dequeue();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}