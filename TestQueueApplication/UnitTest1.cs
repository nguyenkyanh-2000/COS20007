using NUnit.Framework;
using QueueApplication;

namespace TestQueueApplication
{
    public class Tests
    {
        private IntegerQueue _queue;

        [SetUp]
        public void Setup()
        {
            _queue = new IntegerQueue();
        }

        [Test]
        public void TestEnqueue()
        {
            IntegerQueue myQueue = new IntegerQueue();
            myQueue.Enqueue(12345);
            int myCount = myQueue.Count;
            
            Assert.That(myCount, Is.EqualTo(1));
            
            // acessing member variables directly
            Assert.That(myQueue._elements.Count, Is.EqualTo(1));
            Assert.That(myQueue._elements[0], Is.EqualTo(12345));
        }

        [Test]
        public void TestDequeue()
        {
           Assert.Fail();
        }
        
    }
}