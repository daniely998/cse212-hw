using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with multiple items and attempt to remove using Dequeue.
    // Expected Result: Banana
    // Defect(s) Found: returned "Apple" because the Dequeue method was missing the RemoveAt() function and for loop did not go through all items in the queue.
    public void TestPriorityQueue_RemoveHighestPriorityItem()
    {
        var fruits = new PriorityQueue();
        fruits.Enqueue("Apple", 2);
        fruits.Enqueue("Orange", 1);
        fruits.Enqueue("Banana", 3);

        var highest = fruits.Dequeue();
        Assert.AreEqual("Banana", highest);
    }

    [TestMethod]
    // Scenario: Create a queue with multiple items of the same highest priority and attempt to remove using Dequeue.
    // Expected Result: Grapes
    // Defect(s) Found: "Banana" was returned because the Dequeue method was replacing the highPriorityIndex variable with other index of items with the same priority.
    public void TestPriorityQueue_MultipleHighestPriorityItems()
    {
        var fruits = new PriorityQueue();
        fruits.Enqueue("Apple", 2);
        fruits.Enqueue("Grapes", 3);
        fruits.Enqueue("Banana", 3);
        fruits.Enqueue("Orange", 1);

        var removed = fruits.Dequeue();
        Assert.AreEqual("Grapes", removed);
    }

    // Scenario: Trying to Dequeue from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None.
    [TestMethod]
    public void TestPriorityQueue_EmptyQueue()
    {
        var fruits = new PriorityQueue();
        var e = Assert.ThrowsException<InvalidOperationException>(() => fruits.Dequeue());
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}