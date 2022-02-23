using NUnit.Framework;
using System;
using Task;

namespace tests
{
    [TestFixture]
    public class Tests
    {
        MyStack stack;

        [SetUp]
        public void StackCreation()
        {
            stack = new MyStack();
        }


        [Test]
        public void EmptyHasZeroCount()
        {
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void CountWorksCorrectly()
        {
            stack.Push(1);
            stack.Push(1);
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(2, stack.Count);
        }

        [Test]
        public void PushsAndPopsWorkCorrectly()
        {
            stack.Push('a');
            stack.Push(1);
            stack.Push(2.1);
            stack.Pop();
            Assert.AreEqual(1, stack.Pop());
        }

        [Test]
        public void StackPopsToCleanCorrectly()
        {
            stack.Push(1);
            stack.Pop();
            CleanStackDontPops();
        }

        [Test]
        public void CleanStackDontPops()
        {
            var exceptionCatched = false;
            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Stack Is Already Empty!", ex.Message);
                exceptionCatched = true;
            }
            catch(Exception)
            {
                Assert.Fail();
                exceptionCatched = true;
            }
            if (exceptionCatched == false) Assert.Fail(); 
        }

        [Test]
        public void IsEmptyWorksCorrectly1()
        {
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(true, stack.IsEmpty);
        }

        [Test]
        public void IsEmptyWorksCorrectly2()
        {
            stack.Push(1);
            Assert.AreEqual(false, stack.IsEmpty);
        }

        [Test]
        public void ClearWorksCorrectly1()
        {
            stack.Push(1);
            stack.Clear();
            Assert.AreEqual(true, stack.IsEmpty);
        }

        [Test]
        public void ClearWorksCorrectly2()
        {
            stack.Push(1);
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void ClearWorksCorrectly3()
        {
            stack.Push(1);
            stack.Clear();
            CleanStackDontPops();
        }

        [Test]
        public void name()
        {

            Assert.AreEqual(0, 0);
        }
    }
}