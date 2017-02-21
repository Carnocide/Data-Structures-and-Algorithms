using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace DataStructuresAndAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            int size = 0;
            string situation = "";
            string path;
            List<string> algorithm = new List<string>();
            //small
            if ((bool)smallSizeButton.IsChecked)
            {
                size = 100;
            }
            //medium
            else if ((bool)mediumSizeButton.IsChecked)
            {
                size = 1000;
            }
            //large
            else if ((bool)largeSizeButton.IsChecked)
            {
                size = 10000;
            }
            //extralarge
            else if ((bool)extraLargeSizeButton.IsChecked)
            {
                size = 100000;
        
            }
            
            else
            {
                MessageBox.Show("Please select a data size.");
                
            }
            
            if ((bool)idealButton.IsChecked)
            {
                situation = "ideal";
            }
            else if ((bool)worstCaseButton.IsChecked)
            {
                situation = "worstcase";
            }
            else if ((bool)randomButton.IsChecked)
            {
                situation = "shuffled";
            }
            else
            {
                MessageBox.Show("Please select an inital order (situation)");
            }

            if ((bool)bubbleSortBox.IsChecked)
            {
                algorithm.Add("bubble");
            }
            if ((bool)selectionSortBox.IsChecked)
            {
                algorithm.Add("selection");
            }
            if ((bool)insertionSortBox.IsChecked)
            {
                algorithm.Add("insertion");
            }
            if ((bool)sequentialSearchBox.IsChecked)
            {
                algorithm.Add("sequential");
            }
            if ((bool)binarySearchBox.IsChecked)
            { 
                algorithm.Add("binary");
            }
            if ((bool)recursiveBinaryBox.IsChecked)
            {
                algorithm.Add("recursive");
            }
            if ((bool)mergeSortBox.IsChecked)
            {
                algorithm.Add("merge");
            }
            if ((bool)quickSortBox.IsChecked)
            {
                algorithm.Add("quick");
            }


            if (size != 0 || !string.IsNullOrEmpty(situation) || !algorithm.Any())
            {

                DataSet data = new DataSet();
                data.CreateData(size, situation);
                SortingAlgorithmManager algo = new SortingAlgorithmManager();
                SearchingAlgorithmManager searchAlgo = new SearchingAlgorithmManager();
                Stopwatch timer = new Stopwatch();
                string results = "";

                if(!(bool)proofBox.IsChecked)
                {
                    for (int i = 0; i < data.DataList.Count; i++)
                    {
                        results += data.DataList[i].ToString() + " ";
                    }
                    ResultsWindow unsort = new ResultsWindow(results);
                    unsort.Show();

                    results = "";
                }


                if (algorithm.Contains("bubble"))
                {
                    results += "BubbleSort with data size: '" + data.DataList.Count + "' and situation: '" + situation + "'\nTheoretcal best case: O(n), worst case: O(n^2), average: O(n^2). \nIt took ";
                    timer.Start();
                    algo.BubbleSort(data);
                    timer.Stop();
                    results += timer.ElapsedMilliseconds.ToString() + " ms to complete, with '" + algo.comparisons + "' comparisons and '" + algo.transactions + "' transactions.";
                    timer.Reset();
                    algo.ResetCounters();
                }

                if (algorithm.Contains("selection"))
                {
                    results += "SelectionSort with data size: '" + data.DataList.Count + "' and situation: '" + situation + "'\nTheoretcal best case: O(n^2), worst case: O(n^2), average: O(n^2). \nIt took ";
                    timer.Start();
                    algo.InsertionSort(data);
                    timer.Stop();
                    results += timer.ElapsedMilliseconds.ToString() + " ms to complete with '" + algo.comparisons + "' comparisons and '" + algo.transactions + "' transactions.";
                    timer.Reset();
                    algo.ResetCounters();
                }
                if (algorithm.Contains("insertion"))
                {
                    results += "InsertionSort with data size: '" + data.DataList.Count + "' and situation: '" + situation + "'\nTheoretcal best case: O(n) for comparisons, O(1) for swaps, worst case: O(n^2) for comparisons and swaps, average: O(n^2) for comparisons and swaps. \nIt took ";
                    timer.Start();
                    algo.SelectionSort(data);
                    timer.Stop();
                    results += timer.ElapsedMilliseconds.ToString() + " ms to complete with '" + algo.comparisons + "' comparisons and '" + algo.transactions + "' transactions.";
                    timer.Reset();
                    algo.ResetCounters();
                }
                if (algorithm.Contains("sequential"))
                {
                    int desiredValue;
                    int.TryParse(searchBox.Text, out desiredValue);
                    timer.Start();
                    int temp = searchAlgo.SequentialSort(data, desiredValue);
                    timer.Stop();
                    results += "\n\nYour searched entry was found at position: " + temp.ToString() + ". \nIt took: " + timer.ElapsedMilliseconds.ToString() + " ms to complete with " + searchAlgo.comparisons.ToString() + " comparisons.";
                    timer.Reset();
                    searchAlgo.ResetCounters();
                }

                if (algorithm.Contains("binary"))
                {
                    int desiredValue;
                    int.TryParse(searchBox.Text, out desiredValue);
                    timer.Start();
                    int temp = searchAlgo.BinarySearch(data, desiredValue);
                    timer.Stop();
                    results += "\n\nYour searched entry was found at position: " + temp.ToString() + ". \nIt took: " + timer.ElapsedMilliseconds.ToString() + " ms to complete with " + searchAlgo.comparisons.ToString() + " comparisons.";
                    timer.Reset();
                    searchAlgo.ResetCounters();
                }

                if (algorithm.Contains("recursive"))
                {
                    int desiredValue;
                    int.TryParse(searchBox.Text, out desiredValue);
                    timer.Start();
                    int temp = searchAlgo.recursiveBinary(data, desiredValue, data.DataList.Count -1, 0);
                    timer.Stop();
                    results += "\n\nYour searched entry was found at position: " + temp.ToString() + ". \nIt took: " + timer.ElapsedMilliseconds.ToString() + " ms to complete with " + searchAlgo.comparisons.ToString() + " comparisons.";
                    timer.Reset();
                    searchAlgo.ResetCounters();
                }

                if (algorithm.Contains("merge"))
                {
                    SortingAlgorithmManager.MergeSort mergesort = new SortingAlgorithmManager.MergeSort();
                    results += "MergeSort with data size: '" + data.DataList.Count + "' and situation: '" + situation + "'\nTheoretcal best case: O(n log n) for comparisons, O(n log n) for swaps, worst case: O(n ⌈lg n⌉ -2⌈lg n⌉ +1) for comparisons and swaps, average: O(n log n) for comparisons and swaps. \nIt took ";

                   timer.Start();
                    mergesort.SortMerge(data, 0, data.DataList.Count - 1);
                    timer.Stop();
                    results += timer.ElapsedMilliseconds.ToString() + " ms to complete with '" + algo.comparisons + "' comparisons and '" + algo.transactions + "' transactions.";
                    timer.Reset();
                    algo.ResetCounters();

                }

                if (algorithm.Contains("quick"))
                {
                    results += "QuickSort with data size: '" + data.DataList.Count + "' and situation: '" + situation + "'\nTheoretcal best case: O(n log n) for comparisons, O(n log n) for swaps, worst case: O(n^2) for comparisons and swaps, average: O(n log n) for comparisons and swaps. \nIt took ";
                    timer.Start();
                    algo.QuickSort(data, 0, data.DataList.Count - 1);
                    timer.Stop();
                    results += timer.ElapsedMilliseconds.ToString() + " ms to complete with '" + algo.comparisons + "' comparisons and '" + algo.transactions + "' transactions.";
                    timer.Reset();
                    algo.ResetCounters();
                }

                if (!(bool)proofBox.IsChecked)
                {
                    ResultsWindow win2 = new ResultsWindow(results);
                    win2.Show();
                    results = "";

                    for (int i = 0; i < data.DataList.Count; i++)
                    {
                        results += data.DataList[i].ToString() + " ";
                    }
                }
                ResultsWindow sorted = new ResultsWindow(results);
                    sorted.Show();
                    results = "";
                    size = 0;
                    situation = "";
                    path = "";
                    algorithm.Clear();
                
            }
           
                
        }
    }
}
