using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAD.DataProcess
{
    internal class MedianCalculation
    {
        decimal[] data_array;

        public MedianCalculation(decimal[] data_array)
        {
            this.data_array = 
        }

        public decimal ReturnMedian()
        {
            Array.Sort(data_array);

            if (data_array.Length % 2 == 0)
            {
                return ReturnMedianForEvenArray(data_array);
            }
            else
            {
                return ReturnMedianForOddArray(data_array);
            }
        }
        private decimal ReturnMedianForEvenArray(decimal[] data_array)
        {
            int first_mid_index = (data_array.Length / 2) - 1;
            int second_mid_index = (data_array.Length / 2);


            return (data_array[first_mid_index] + data_array[second_mid_index]) / 2m;
        }
        private decimal ReturnMedianForOddArray(decimal[] data_array)
        {
            int index = data_array.Length / 2;
            return data_array[index];
        }
    }
}
