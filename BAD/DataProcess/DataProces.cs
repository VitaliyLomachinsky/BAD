using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BAD.DataProcess
{
    internal class DataProces
    {
        public decimal[] data_array;
        SequenceCounter sequence_counter = new SequenceCounter();
        MedianCalculation median_calculation;

        public DataProces(string[] file_data)
        {

            data_array = new decimal[file_data.Length];
            MedianCalculation median_calculation = new MedianCalculation(data_array);


            for (int i = 0; i < file_data.Length; i++) {
                data_array[i] = Int32.Parse(file_data[i]);
            }
       

            Console.WriteLine("MEDIANA - "+median_calculation.ReturnMedian());

            sequence_counter.CalculateGrowthSequence(data_array);
            sequence_counter.PrintGrowsSequence();
        }
        public decimal ReturnMinValue()
        {
            return data_array[0];
        }
        public decimal ReturnMaxValue()
        {
            return data_array[data_array.Length-1];
        }
        public decimal ReturnAverageValue(){
            decimal sum = 0;
            for(int i=0;i<data_array.Length;i++)
            {
                sum += data_array[i];
            }
            return sum / data_array.Length;
        }

     
    }
}
