using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructuresAndAlgorithms
{
    public class SortingAlgorithmManager
    {
        public int comparisons = 0;
        public int transactions = 0;

        // Bubble sort algorithm
        // Compares two values next to each other and switches them if they are in the wrong order
        public void BubbleSort(DataSet data)
        {
            
            int temp = 0;

            // This loop keeps track of how many times it has gone through 
            // The counter value of i is subtracted from the number of iterations the second loop must go through
            for (int i = 0; i < data.DataList.Count; i++)
            {

                // Compares 2 adjacent values within the data set, gets smaller by 1 each time the first loop increments
                for (int j = 0; j < data.DataList.Count - i - 1; j++)
                {
                    // The comparison
                    if ((int)data.DataList[j] > (int)data.DataList[j + 1])
                    {
                        temp = (int)data.DataList[j + 1];
                        data.DataList[j + 1] = data.DataList[j];
                        data.DataList[j] = temp;
                        transactions++;
                    }
                    comparisons++;

                }
            }
            
        }

        // Selection Sort
        // Compares items in the array starting at a specific point. Moves the smallest value in the array up to that specified point.
        public void SelectionSort(DataSet data)
        {
            // The index of the lowest value within the array
            int small;
            int temp;

            // Starts the comparisons at the beginning of the array
            // The starting index is incremented each time through
            // sets the index of the smallest number to the first number to be compared
            for (int i = 0; i < data.DataList.Count - 1; i++)
            {
                
                small = i;

                // Starts at the value of i+1 and increments until the end of the array
                for (int j = i + 1; j < data.DataList.Count; j++)
                {
                    // compares the value of j to the value of the smallest number, if it is smaller, the index of the smallest number is set to j
                    if ((int)data.DataList[j] < (int)data.DataList[small])
                    {
                        
                        small = j;
                    }
                }

                // If the smallest number is not already at the beginning of the array, it is swapped out.
                if (small != i)
                {
                    temp = (int)data.DataList[i];
                    data.DataList[i] = data.DataList[small];
                    data.DataList[small] = temp;
                    transactions++;
                }
                comparisons++;
            }
            
        }

        // Insertion Sort
        // Separates the array into sorted and unsorted. Compares the first value in the unsorted array and places it within the sorted array
        public void InsertionSort(DataSet data)
        {
            for (int i = 0; i < data.DataList.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if ((int)data.DataList[j - 1] > (int)data.DataList[j])
                    {
                        int temp = (int)data.DataList[j - 1];
                        data.DataList[j - 1] = data.DataList[j];
                        data.DataList[j] = temp;
                        transactions++;
                    }
                    comparisons++;
                }
            }
        }


        // Merge Sort
        // Splits the array into halves until they are in the smallest possible 'pieces'
        // Compares the individual pieces then merges them based on order
        // Takes the lowest values of the new merged units and compares them, putting them in order until the array is sorted
        public class MergeSort
        {
            public int comparisons = 0;
            public int transactions = 0;

            // sorts the smallest parts from SortMerge
            public void MainMerge(DataSet data, int left, int mid, int right)
            {
                int[] temp = new int[data.DataList.Count];
                int i, eol, num, pos;

                
                eol = (mid - 1);

                pos = left;
                num = (right - left + 1);

                comparisons++;
                while ((left <= eol) && (mid <= right))
                {
                    comparisons++;
                    if ((int)data.DataList[left] <= (int)data.DataList[mid])
                    {
                        transactions++;
                        temp[pos++] = (int)data.DataList[left++];
                    }
                    else
                    {
                        transactions++;
                        temp[pos++] = (int)data.DataList[mid++];
                    }
                        
                }
                comparisons++;
                while (left <= eol)
                {
                    transactions++;
                    temp[pos++] = (int)data.DataList[left++];
                }
                comparisons++;
                while (mid <= right)
                {
                    transactions++;
                    temp[pos++] = (int)data.DataList[mid++];
                }
                comparisons++;
                for (i = 0; i < num; i++)
                {
                    transactions++;
                    data.DataList[right] = temp[right];
                    right--;
                }
            }

            // Splits the array into its smallest parts
            public void SortMerge(DataSet data, int left, int right)
            {
                int mid;

                if (right > left)
                {
                    mid = (right + left) / 2;
                    SortMerge(data, left, mid);
                    SortMerge(data, (mid + 1), right);

                    MainMerge(data, left, (mid + 1), right);
                }
            }
            public void ResetCounters()
            {
                comparisons = 0;
                transactions = 0;
            }
        }

        // called recursively with the quicksort function initially
        // moves the pivot
        public int Partition(DataSet data, int left, int right)
        {
            int pivot = (int)data.DataList[left];
            while (true)
            {
                comparisons++;
                while ((int)data.DataList[left] < pivot)
                    left++;
                comparisons++;
                while ((int)data.DataList[right] > pivot)
                    right--;
                comparisons++;
                if (left < right)
                {
                    transactions++;
                    int temp = (int)data.DataList[right];
                    data.DataList[right] = (int)data.DataList[left];
                    data.DataList[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        // Quick Sort
        // Sorts the array by moving values higher or lower than the pivot to the correct side 
        public void QuickSort(DataSet data, int left, int right)
        {
            
            comparisons++;
            if (left < right)
            {
                
                int pivot = Partition(data, left, right);
                comparisons++;
                if (pivot > 1)
                    QuickSort(data, left, pivot - 1);
                comparisons++;
                if (pivot + 1 < right)
                    QuickSort(data, pivot + 1, right);
            }
        }

        public void ResetCounters()
        {
            comparisons = 0;
            transactions = 0;
        }
    }
}
