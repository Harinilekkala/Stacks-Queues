// See https://aka.ms/new-console-template for more information
namespace StacksAndQueues
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------Welcome to concept of stack(push and pop operation)--------------");
            LinkedListStack value = new LinkedListStack();
            value.push(70);
            value.push(30);
            value.push(56);
            value.DisPlay();
            value.Peek();
            value.Pop();
            value.IsEmpty();

            Console.WriteLine("-----------------Welcome to concept of Queue(enque&dequeue)---------------");
            StacksAndQueues.LinkedListQueue Queue = new StacksAndQueues.LinkedListQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.DisPlay();
            Queue.Dequeue();


        }
    }
}