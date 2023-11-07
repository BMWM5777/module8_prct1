using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para228
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray array = new RangeOfArray(-9, 15);

            array[-9] = 42;
            array[1] = 100;          // Индекс 1 соответствует 6 в пользовательском диапазоне
            array[20] = 200;        // Будет выскакивать исключение, так как 20 вне диапазона
            int value = array[10]; // value содержит значение по индексу 10
        }
    }
    public class RangeOfArray
    {
         private int[] array;
         private int lowBound;
         private int upBound;

        public RangeOfArray(int lowBound, int upBound)
        {
            this.lowBound = lowBound;
            this.upBound = upBound;
            int length = upBound - lowBound + 1;
            array = new int[length];
        }
        public int this[int index]
        {
            get
            {
                if (IsInRange(index))
                {
                    return array[index - lowBound];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
            set
            {
                if (IsInRange(index))
                {
                    array[index - lowBound] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
        }
            private bool IsInRange(int index)
        {
            return index >= lowBound && index <= upBound;
        }
        private bool IsOutRange(int index) 
        {
            return index < lowBound && index >= upBound;
        }
    }
}
