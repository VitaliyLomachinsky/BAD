using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BAD.DataProcess
{
    internal class DataAnalysis
    {
        public decimal[] data_array;

        SequenceCounter sequence_counter;
        MedianCalculation median_calculation;

        public DataAnalysis(string[] file_data)
        {
            data_array = new decimal[file_data.Length];
            InitializationOfAnArrayOfNumbers(file_data);
            sequence_counter = new SequenceCounter(data_array);
            median_calculation = new MedianCalculation();

           

            Array.Sort(data_array);

        }
        private void InitializationOfAnArrayOfNumbers(string[] file_data)
        {
            for (int i = 0; i < file_data.Length; i++)
            {
                data_array[i] = Int32.Parse(file_data[i]);
            }
        }

        public void PrintHandledFileInfo()
        {
            Console.WriteLine("MAX VALUE: " + ReturnMaxValue());
            Console.WriteLine("MIN VALUE: " + ReturnMinValue());
            Console.WriteLine("AVARAGE VALUE: " + ReturnAverageValue());
            Console.WriteLine("MEDIAN: " + ReturnMedian());

            Console.WriteLine("\n" + "Longest increasing sequence:");
            foreach (decimal item in ReturnLongestIncreasingSequence()) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + "Longest decreasing sequence:");
            foreach (decimal item in ReturnLongestDecreasingSequence())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        private decimal ReturnMinValue()
        {
            return data_array[0];
        }
        private decimal ReturnMaxValue()
        {
            return data_array[data_array.Length-1];
        }
        private decimal ReturnAverageValue(){
            decimal sum = 0;
            for(int i=0;i<data_array.Length;i++)
            {
                sum += data_array[i];
            }
            return sum / data_array.Length;
        }
        private decimal ReturnMedian()
        {
            return median_calculation.ReturnMedian(data_array);
        }
        private List<decimal> ReturnLongestIncreasingSequence()
        {
            return sequence_counter.ReturnIncreasingSequence();
        }
        private List<decimal> ReturnLongestDecreasingSequence()
        {
            return sequence_counter.ReturnDecreasingSequence();
        }

    }
}
