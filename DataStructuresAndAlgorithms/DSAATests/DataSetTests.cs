using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms;
using System.Collections.Generic;

namespace DSAATests
{
    [TestClass]
    public class DataSetTests
    {
        #region Initial Tests
        [TestMethod]
        public void CanInstantiateDataSet()
        {
            DataSet data = new DataSet();
        }

        [TestMethod]
        public void InitialDataArrayNull()
        {
            DataSet data = new DataSet();
            Assert.AreEqual(null, data.DataList);
        }
        #endregion

        #region SmallDataSets

        [TestMethod]
        public void CreateSmallDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100, "");
            Assert.AreEqual(100, data.DataList.Count);

        }
        [TestMethod]
        public void CreateSmallIdealDataSet()
        {

            DataSet data = new DataSet();
            data.CreateData(100, "ideal");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(100, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(1, data.DataList[0]);
            Assert.AreEqual(100, data.DataList.Count);


        }

        [TestMethod]
        public void CreateSmallWorstCaseDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100, "worstcase");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(data.DataList.Count - i, data.DataList[i]);
            }
            Assert.AreEqual(1, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(100, data.DataList[0]);
            Assert.AreEqual(100, data.DataList.Count);
        }

        [TestMethod]
        public void CreateSmallShuffledDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100, "shuffled");
            bool fail = true;
            for (int i = 0; i < data.DataList.Count; i++)
            {
                if (data.DataList[i].ToString() != (i + 1).ToString())
                    fail = false;
            }
            if (fail)
                Assert.Fail();
        }


        [TestMethod]
        public void CreateSmallThenClear()
        {
            DataSet data = new DataSet();
            data.CreateData(100, "");
            Assert.AreEqual(100, data.DataList.Count);
            data.ClearData();
            Assert.AreEqual(null, data.DataList);

        }
        #endregion

        #region MediumDataSets
        [TestMethod]
        public void CreateMediumDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "");
            Assert.AreEqual(1000, data.DataList.Count);

        }

        [TestMethod]
        public void CreateMediumIdealDataSet()
        {

            DataSet data = new DataSet();
            data.CreateData(1000, "ideal");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(1000, data.DataList[data.DataList.Capacity - 1]);
            Assert.AreEqual(1, data.DataList[0]);
        }

        [TestMethod]
        public void CreateMediumWorstCaseDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "worstcase");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(data.DataList.Count - i, data.DataList[i]);
            }
            Assert.AreEqual(1, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(1000, data.DataList[0]);
        }

        [TestMethod]
        public void CreateMediumShuffledDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "shuffled");
            bool fail = true;
            for (int i = 0; i < data.DataList.Count; i++)
            {
                if (data.DataList[i].ToString() != (i + 1).ToString())
                    fail = false;
            }
            if (fail)
                Assert.Fail();
        }

        [TestMethod]
        public void CreateMediumThenClear()
        {
            DataSet data = new DataSet();
            data.CreateData(1000, "");
            data.ClearData();
            Assert.AreEqual(null, data.DataList);
        }

        #endregion

        #region LargeDataSets
        [TestMethod]
        public void CreateLargeDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(10000, "");
            Assert.AreEqual(10000, data.DataList.Count);

        }

        [TestMethod]
        public void CreateLargeIdealDataSet()
        {

            DataSet data = new DataSet();
            data.CreateData(10000, "ideal");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(10000, data.DataList[data.DataList.Capacity - 1]);
            Assert.AreEqual(1, data.DataList[0]);
        }

        [TestMethod]
        public void CreateLargeWorstCaseDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(10000, "worstcase");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(data.DataList.Count - i, data.DataList[i]);
            }
            Assert.AreEqual(1, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(10000, data.DataList[0]);
        }

        [TestMethod]
        public void CreateLargeShuffledDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(10000, "shuffled");
            bool fail = true;
            for (int i = 0; i < data.DataList.Count; i++)
            {
                if (data.DataList[i].ToString() != (i + 1).ToString())
                    fail = false;
            }
            if (fail)
                Assert.Fail();
        }

        [TestMethod]
        public void CreateLargeThenClear()
        {
            DataSet data = new DataSet();
            data.CreateData(10000, "");
            data.ClearData();
            Assert.AreEqual(null, data.DataList);
        }

        #endregion

        #region ExtraLargeDataSets
        [TestMethod]
        public void CreateExtraLargeDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100000, "");
            Assert.AreEqual(100000, data.DataList.Count);

        }

        [TestMethod]
        public void CreateExtraLargeIdealDataSet()
        {

            DataSet data = new DataSet();
            data.CreateData(100000, "ideal");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(i + 1, data.DataList[i]);
            }
            Assert.AreEqual(100000, data.DataList[data.DataList.Capacity - 1]);
            Assert.AreEqual(1, data.DataList[0]);
        }
        [TestMethod]
        public void CreateExtraLargeWorstCaseDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100000, "worstcase");
            for (int i = 0; i < data.DataList.Count; i++)
            {
                Assert.AreEqual(data.DataList.Count - i, data.DataList[i]);
            }
            Assert.AreEqual(1, data.DataList[data.DataList.Count - 1]);
            Assert.AreEqual(100000, data.DataList[0]);
        }

        [TestMethod]
        public void CreateExtraLargeShuffledDataSet()
        {
            DataSet data = new DataSet();
            data.CreateData(100000, "shuffled");
            bool fail = true;
            for (int i = 0; i < data.DataList.Count; i++)
            {
                if (data.DataList[i].ToString() != (i + 1).ToString())
                    fail = false;
            }
            if (fail)
                Assert.Fail();
        }

        [TestMethod]
        public void CreateExtraLargeThenClear()
        {
            DataSet data = new DataSet();
            data.CreateData(100000, "");
            data.ClearData();
            Assert.AreEqual(null, data.DataList);
        }

        #endregion

    }
}
