using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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

    // Add more test cases as needed below.
    [TestMethod]
    public void TestPriorityQueue_EmptyQueue()
    {
        var fruits = new PriorityQueue();
        var e = Assert.ThrowsException<InvalidOperationException>(() => fruits.Dequeue());
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}