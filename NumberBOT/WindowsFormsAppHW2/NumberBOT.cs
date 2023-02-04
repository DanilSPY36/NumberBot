using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHW2
{
    internal class NumberBOT
    {
        private int[] _numbers;
        public int _triesAmount { get; set; }
        public int searchedValue { get; set; }
        public NumberBOT()
        {
            _numbers = new int[2001];
            _triesAmount = 0;
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = i;
            }
        }
        private int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }
            var middle = (first + last) / 2;
            var middleValue = _numbers[middle];

            if (searchedValue == middleValue)
            {
                _triesAmount++;
                this.searchedValue = searchedValue;
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    _triesAmount++;
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    _triesAmount++;
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
        public override string ToString()
        {
            return $"нашел число: {searchedValue} за {_triesAmount} попыток.";
        }
        public void Search()
        {
            searchedValue = BinarySearch(_numbers, searchedValue, 0, _numbers.Length - 1);
        }
    }
}
