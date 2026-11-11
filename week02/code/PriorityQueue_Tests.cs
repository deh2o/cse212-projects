using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    //Scenario: Add three items with different priorities.
    // Expected Result: Items should remain in their original
    // enqueue order because Enqueue always adds to the back. 
    // Defect(s) Found: None. Items were added to the back of the queue correctly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Orange", 5);
        priorityQueue.Enqueue("Banana", 1);

        Assert.AreEqual(
            "[Apple (Pri:2), Orange (Pri:5), Banana (Pri:1)]",
            priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Add three items with different priorities and
    // dequeue them until the queue is empty.
    // Expected Result: The highest-priority item should be
    // returned first, and each returned item should be removed.
    // Defect(s) Found: The method failed to identify the item with the highest
    // priority because the loop did not examine the last item in the queue.
    // It also failed to remove dequeued items from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Orange", 5);
        priorityQueue.Enqueue("Banana", 8);

        Assert.AreEqual("Banana", priorityQueue.Dequeue());
        Assert.AreEqual("Orange", priorityQueue.Dequeue());
        Assert.AreEqual("Apple", priorityQueue.Dequeue());

        Assert.AreEqual("[]", priorityQueue.ToString());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: Items should be dequeued in FIFO order.
    // Defect(s) Found: The method selected the later item when priorities
    // were equal instead of maintaining FIFO order.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 5);
        priorityQueue.Enqueue("Orange", 5);
        priorityQueue.Enqueue("Banana", 2);
        priorityQueue.Enqueue("Mango", 5);

        Assert.AreEqual("Apple", priorityQueue.Dequeue());
        Assert.AreEqual("Orange", priorityQueue.Dequeue());
        Assert.AreEqual("Mango", priorityQueue.Dequeue());
        Assert.AreEqual("Banana", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue an item from an empty queue.
    // Expected Result: InvalidOperationException should be thrown
    // with the message "The queue is empty."
    // Defect(s) Found: None. The correct InvalidOperationException
    // was thrown with the required error message.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}