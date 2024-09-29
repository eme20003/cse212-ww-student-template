using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add multiple users, match it with expected list and priority (see if it added it to back of queue)
    // Expected Result: true
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        var bob = new PriorityItem("Bob", 1);
        var steve = new PriorityItem("Steve", 1);
        var kevin = new PriorityItem("Kevin", 1);

        PriorityItem[] expectedResult = [bob, steve, kevin];

        var priorityEnqueue = new PriorityQueue();
        priorityEnqueue.Enqueue(bob.Value, bob.Priority);
        priorityEnqueue.Enqueue(steve.Value, steve.Priority);
        priorityEnqueue.Enqueue(kevin.Value, kevin.Priority);

        for (int i = 0; i < 3; i++)
        {
            Assert.AreEqual(expectedResult[i].Value, priorityEnqueue.Value);
        }

        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Look at queue priority if popped off, it should equal the highest priority from results
    // Expected Result: True
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    //Senario: If person has a same priority as someone else, then lowest index should be removed, and value returned
    //Test Result: True
        public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    //Senario: If queue is empty then throw exception
    //Test Result: True
            public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }
}