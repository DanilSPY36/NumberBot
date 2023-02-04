using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHW2
{
    public class NumberCreator
    {
        public int _number { get; set; }
        public int _amountOfTries { get; set; }
        public NumberCreator(int number, int tries)
        {
            _number = number;
            _amountOfTries = tries;
        }
        public NumberCreator() { }
        public override string ToString()
        {
            return $"Загаданное число: {_number} | Количество попыток на разгадку: {_amountOfTries}";
        }
    }
}
