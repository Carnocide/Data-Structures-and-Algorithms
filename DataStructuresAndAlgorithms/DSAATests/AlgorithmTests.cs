using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms;


namespace DSAATests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "worstcase");
            SortingAlgorithmManager algo = new SortingAlgorithmManager();
            algo.BubbleSort(data);
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(1000, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(1, data.DataList[0]);
            Assert.AreEqual(1000, data.DataList.Count);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "shuffled");
            SortingAlgorithmManager algo = new SortingAlgorithmManager();
            algo.SelectionSort(data);
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(1000, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(1, data.DataList[0]);
            Assert.AreEqual(1000, data.DataList.Count);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "shuffled");
            SortingAlgorithmManager algo = new SortingAlgorithmManager();
            algo.InsertionSort(data);
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(1000, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(1, data.DataList[0]);
            Assert.AreEqual(1000, data.DataList.Count);
        }
    }
}
