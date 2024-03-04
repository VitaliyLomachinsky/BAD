using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAD.DataProcess
{
    internal class SequenceCounter
    {
        decimal[] data_array;

        List<decimal> sequence_of_increasing_numbers = new List<decimal>();
        List<decimal> sequence_of_decreasing_numbers = new List<decimal>();

        public SequenceCounter(decimal[] data)
        {
            data_array =data;
        }
        public void CalculateSequences(decimal[] data_array)
        {
            InitialListsByFirstNumber();
            List<decimal> temp_increase = new List<decimal>();
            List<decimal> temp_decrease = new List<decimal>();

            for (int i = 0; i < data_array.Length; i++)
            {
                if (temp_sequence_of_increase_numbers.Last() < data_array[i])
                {
                    temp_sequence_of_increase_numbers.Add(data_array[i]);
                }
                else
                {
                    ChangeFinalSequenceIfTempIsBigger();
                    temp_sequence_of_increase_numbers.Clear();
                    IfArrayEmptyInitialByNextNumber(temp_sequence_of_increase_numbers, data_array[i]);
                }
            }
            ChangeFinalSequenceIfTempIsBigger();
        }
        private void InitialListsByFirstNumber()
        {
            sequence_of_increasing_numbers.Add(data_array[0]);
            sequence_of_decreasing_numbers.Add(data_array[0]);
        }
        private void IncreaseCounter(List<decimal> temp_increase,decimal number)
        {
            if (temp_increase.Last() < number)
            {
                temp_increase.Add(number);
            }
        }

        private void DecreaseCounter(decimal number)
        {

        }

        private void ChangeFinalSequenceIfTempIsBigger()
        {
            if (final_sequence_of_grows_numbers.Count < temp_sequence_of_grows_numbers.Count)
            {
                final_sequence_of_grows_numbers = new List<decimal>(temp_sequence_of_grows_numbers);
            }
        }

        public List<decimal> ReturnIncreasingSequence()
        {
            return final_sequence_of_increase_numbers;
        }

        public List<decimal> ReturnDecreasingSequence()
        {
            return final_sequence_of_decrease_numbers;
        }
    }
}
