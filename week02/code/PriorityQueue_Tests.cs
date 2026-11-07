using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and their priority putting the highest priority at the end of the queue. Stan(3), Jude(5), Ruti(2), Kyle(10)
    // Expected Result: Kyle, Jude, Stan, Ruti
    // Defect(s) Found: Expected kyle to be first but got Jude. Highest priority at the end was never compared. Made a fix, got another Defect. 
    // second Dequeue got Kyle but didnt return jude.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Stan", 3);
        priorityQueue.Enqueue("Jude", 5);
        priorityQueue.Enqueue("Ruti", 2);
        priorityQueue.Enqueue("Kyle", 10);

        string[] expectedResult = ["Kyle", "Jude", "Stan", "Ruti"];

        foreach (var expected in expectedResult)
        {
            Assert.AreEqual(expected, priorityQueue.Dequeue());
        }

    }

    [TestMethod]
    // Scenario: Enqueue this in order of: Stan(9), Jude(2), Ruti(9), Kyle(4)
    // Expected Result: Stan, Ruti, Kyle, Jude
    // Defect(s) Found: Expected Stan but got Ruti. The comparison picked the later name on a tie instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Stan", 9);
        priorityQueue.Enqueue("Jude", 2);
        priorityQueue.Enqueue("Ruti", 9);
        priorityQueue.Enqueue("Kyle", 4);

        string[] expectedResult = ["Stan", "Ruti", "Kyle", "Jude"];

        foreach (var expected in expectedResult)
        {
            Assert.AreEqual(expected, priorityQueue.Dequeue());
        }

    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Results: Exception should be thrown with appropriate message
    // Defect(s) Found: No defects
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                String.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
    // Add more test cases as needed below.
}