using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAD.DataProcess
{
    internal class SequenceCounter
    {
        List<decimal> final_sequence_of_grows_numbers = new List<decimal>();
        List<decimal> temp_sequence_of_grows_numbers = new List<decimal>();


        public void CalculateGrowthSequence(decimal[] data_array)
        {
            IfArrayEmptyInitialByNextNumber(temp_sequence_of_grows_numbers, data_array[0]);

            for (int i = 0; i < data_array.Length; i++)
            {
                if (temp_sequence_of_grows_numbers.Last() < data_array[i])
                {
                    temp_sequence_of_grows_numbers.Add(data_array[i]);
                }
                else
                {
                    ChangeFinalSequenceIfTempIsBigger();
                    temp_sequence_of_grows_numbers.Clear();
                    IfArrayEmptyInitialByNextNumber(temp_sequence_of_grows_numbers, data_array[i]);
                }
            }
            ChangeFinalSequenceIfTempIsBigger();
            temp_sequence_of_grows_numbers = null;
        }

        private void IfArrayEmptyInitialByNextNumber(List<decimal> array, decimal number)
        {
            if (array.Count == 0)
            {
                array.Add(number);
            }
        }

        private void ChangeFinalSequenceIfTempIsBigger()
        {
            if (final_sequence_of_grows_numbers.Count < temp_sequence_of_grows_numbers.Count)
            {
                final_sequence_of_grows_numbers = new List<decimal>(temp_sequence_of_grows_numbers);
            }
        }

        public void PrintGrowsSequence()
        {
            foreach (decimal number in final_sequence_of_grows_numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
