using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BAD.DataProcess
{
    internal class SequenceCounter
    {
        decimal[] data_array;

        List<decimal> sequence_of_increasing_numbers = new List<decimal>();
        List<decimal> sequence_of_decreasing_numbers = new List<decimal>();

        List<decimal> temp_increase = new List<decimal>();
        List<decimal> temp_decrease = new List<decimal>();

        public SequenceCounter(decimal[] data)
        {
            data_array=data;
            temp_increase.Add(data_array[0]);
            temp_decrease.Add(data_array[0]);
            CalculateSequences();
        }
        private void CalculateSequences()
        {
            foreach (decimal number in data_array)
            {
                if (temp_decrease.Last() > number)
                {
                    temp_decrease.Add(number);
                }
                else
                {
                    UpdateDecreaseSequenceIfTempLonger(number);
                }

                if (temp_increase.Last() < number)
                {
                    temp_increase.Add(number);
                }
                else
                {
                    UpdateIncreaseSequenceIfTempLonger(number);
                }
            }
            UpdateDecreaseSequenceIfTempLonger(0);
            UpdateIncreaseSequenceIfTempLonger(0);

        }

        private void UpdateIncreaseSequenceIfTempLonger(decimal number)
        {
            if (temp_increase.Count > sequence_of_increasing_numbers.Count)
            {
                sequence_of_increasing_numbers = new List<decimal>(temp_increase);
            }
            temp_increase.Clear();
            temp_increase.Add(number);
        }

        private void UpdateDecreaseSequenceIfTempLonger(decimal number)
        {
            if (temp_decrease.Count > sequence_of_decreasing_numbers.Count)
            {
                sequence_of_decreasing_numbers = new List<decimal>(temp_decrease);
            }
            temp_decrease.Clear();
            temp_decrease.Add(number);
        }

        public List<decimal> ReturnIncreasingSequence()
        {
            return sequence_of_increasing_numbers;
        }

        public List<decimal> ReturnDecreasingSequence()
        {
            return sequence_of_decreasing_numbers;
        }
    }
}
