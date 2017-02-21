using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace DataStructuresAndAlgorithms
{
    public class DataSet
    {
        
        public ArrayList DataList { get; set; }
        public DataSet()
        {
        }

        public void CreateData(int size, string situation)
        {


            //the size of the array
            DataList = new ArrayList(size);
            for (int i = 0; i < size; i++)
            {
                DataList.Add(i +1);
            }

            //determines the order of the data set

            switch (situation)
            {
                // ideal data set is a a scenario where all the objects are in order
                case "ideal":
                    for (int i = 1; i <= DataList.Count; i++)
                    {
                        DataList[i-1] = i;
                    }
                    break;

                case "worstcase":
                    for (int i = 0; i < DataList.Count; i++)
                    {
                        DataList[i] = DataList.Count - i;
                    }
                    break;

                case "shuffled":
                    {
                        Random rand = new Random();
                        int n = DataList.Count;

                        for (int i = 1; i <= DataList.Count; i++)
                        {
                            DataList[i - 1] = i;
                        }
                        
                        while (n > 1)
                        {
                            n--;
                            int k = rand.Next(n + 1);
                            var value = DataList[k];
                            DataList[k] = DataList[n];
                            DataList[n] = value;
                        }
                        break;
                        
                        
                        
                    }

            }
            
            
            
        }
        
        public void LoadData(string path)
        {
            if (path == "testpath")
                path = "C:\\test.xml";
            
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            DataList = new ArrayList();
            foreach (XmlNode xnode in xdoc.DocumentElement.ChildNodes)
            {
                
                DataList.Add(xnode.InnerText);
            }
        }
        public void ClearData()
        {
            DataList = null;
        }
        
    }
}