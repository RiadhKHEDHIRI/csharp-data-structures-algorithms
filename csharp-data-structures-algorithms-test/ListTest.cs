using csharp_data_structures_algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp_data_structures_algorithms_test
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void EmptyListHasZeroCount()
        {
            var list = new List();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void AddElementShouldIncreaseTheCount()
        {
            var list = new List();
            list.Add("hello");
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void RemoveElementShouldDecreaseTheCount()
        {
            var list = new List();

            list.Add("hello");
            Assert.AreEqual(1, list.Count);

            list.Remove();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void OverRemoveElementShouldNotCauseProblem()
        {
            var list = new List();

            list.Add("hello");
            Assert.AreEqual(1, list.Count);

            list.Remove();
            Assert.AreEqual(0, list.Count);

            list.Remove();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void AddElementShouldBeRetrieved()
        {
            var list = new List();

            list.Add("hello");
            Assert.AreEqual("hello", list.Head());

            list.Add(123);
            Assert.AreEqual(123, list.Head());
        }

        [TestMethod]
        public void RemoveElementShouldBeDeleted()
        {
            var list = new List();

            list.Add("hello");
            Assert.AreEqual("hello", list.Head());

            list.Add(123);
            Assert.AreEqual(123, list.Head());

            list.Remove();
            Assert.AreEqual("hello", list.Head());
        }
    }
}