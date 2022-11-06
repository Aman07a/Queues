using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // Defining a queue of integers
            // Queue<int> queue = new Queue<int>();

            // // Printing the element at the front of the queue
            // queue.Enqueue(1);
            // Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            // queue.Enqueue(2);
            // Console.WriteLine("Top value in the queue is: {0}", queue.Peek());
            // queue.Enqueue(3);
            // int queueItem = queue.Dequeue();
            // Console.WriteLine("Top value in the queue is: {0}", queue.Peek());

            // while (queue.Count > 0)
            // {
            //     // Dequeue() will return the element that was removed from the queue
            //     Console.WriteLine("Current queue count is: {0}", queue.Dequeue());
            //     // Print the queue count
            //     Console.WriteLine("Currentn queue count is: {0}", queue.Count);
            // }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                // Add each order to the same
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                // Add each order to the same
                ordersQueue.Enqueue(o);
            }

            // As long the queue is not empty
            while (ordersQueue.Count > 0)
            {
                // Remove the order at the front of the queue
                // And store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // Process the order
                currentOrder.ProcessOrder();
            }

            Console.Read();
        }

        // This method will create an array of orders and return it
        static Order[] ReceiveOrdersFromBranch1()
        {
            // Creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10),
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            // Creating new orders array and initializing it with some objects of type order
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10),
            };
            // Return the array of orders that we created
            return orders;
        }
    }

    class Order
    {
        // Order ID
        public int OrderId { get; set; }
        // Quantity of the order
        public int OrderQuantity { get; set; }
        // Simple Constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        // Print message on the screen that the order was processed
        public void ProcessOrder()
        {
            // Print the message
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
