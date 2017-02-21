using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SearchingAlgorithmManager
    {
        public int comparisons =0;
        
        // Checks each individual value in order
        public int SequentialSort(DataSet data, int desiredValue)
        {
            
            for (int i = 0; i < data.DataList.Count; i++)
            {
                comparisons++;
                if ((int)data.DataList[i] == desiredValue)
                {
                    return i;
                }
                
            }
            return -1;
        }

        // Binary Search
        // Splits the array in to halves to find the desired number
        public int BinarySearch(DataSet data, int desiredValue)
        {
            comparisons = 0;
            int highestIndex = data.DataList.Count - 1;
            int lowestIndex = 0;
            int index;

            //check for the desired number is the highest index before the Loop, since once the loop starts the highest value will change to the middle value, which is checked
            comparisons++;
            if ((int)data.DataList[highestIndex] == desiredValue)
            {
                return highestIndex;
            }
            

            // maximum number of iterations is log base 2 of the size of the array rounded up
            for (int i = 0; i < Math.Ceiling(Math.Log((data.DataList.Count), 2)); i++)
            {
                comparisons++;
                // index changes each iteration since highestindex and lowest index change
                index = (highestIndex + lowestIndex) / 2;

                // checks if the middle value higher than the desired value, if so changes the highest value to the current middle value
                // otherwise checks if the middle value is lower than the desired value, if so changes the lowest value to the middle value
                // otherwise checks if the middle value is equal to the desired value, if so returns the middle value.
                if ((int)data.DataList[index] > desiredValue)
                {
                    highestIndex = index;

                }
                else if ((int)data.DataList[index] < desiredValue)
                {
                    lowestIndex = index;
                }
                else if ((int)data.DataList[index] == desiredValue)
                {

                    return index;
                }

            }
            return -1;
        }

        // Binary search
        // Recursively
        public int recursiveBinary(DataSet data, int desiredValue, int max, int min)
        {
            comparisons++;
            if (min > max)
            {
                return -1;
            }
            if ((int)data.DataList[max] == desiredValue)
                return max;

            int mid = ((max + min) / 2);



            if ((int)data.DataList[mid] < desiredValue)
            {

                return recursiveBinary(data, desiredValue, max, mid);
            }

            else if ((int)data.DataList[mid] > desiredValue)
            {

                return recursiveBinary(data, desiredValue, mid, min);
            }
            else
            {
                return mid;
            }
        }



        public void ResetCounters()
        {
            comparisons = 0;
            
        }


    }



}
