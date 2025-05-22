using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and dequeue them
    // Expected Result: Theitems with the hieghest priority should be dequeued first
    // Defect(s) Found: none
    public void TestPriorityQueue_0()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 1);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Enqueue("Task 3", 3);

        Assert.AreEqual("Task 3", priorityQueue.Dequeue());
        Assert.AreEqual("Task 2", priorityQueue.Dequeue());
        Assert.AreEqual("Task 1", priorityQueue.Dequeue());
    }
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException should be thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 1);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();


        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
            return;
        }







        // If we reach here, the exception was not thrown



        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}