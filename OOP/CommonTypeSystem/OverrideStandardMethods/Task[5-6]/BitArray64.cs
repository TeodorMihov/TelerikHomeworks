namespace OverrideStandardMethods.Task5_6
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; private set; }

        public static bool operator ==(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            IsNull(firstNumber, secondNumber);

            if (Equals(firstNumber, secondNumber))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            IsNull(firstNumber, secondNumber);

            if (!Equals(firstNumber, secondNumber))
            {
                return true;
            }

            return false;
        }
        private static void IsNull(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
            {
                throw new ArgumentNullException("Object is not the right type");
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 comparisonNumber = obj as BitArray64;

            if (comparisonNumber == null)
            {
                throw new ArgumentNullException("Object is not the right type");
            }

            if (this.Number == comparisonNumber.Number)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (int)(this.Number ^ 42);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                ulong mask = 1;
                ulong position = mask << index;
                if (((int)(position & this.Number)) == 0)
                {
                    return 0;
                }

                return 1;
            }

            set
            {
                if (index != 0 && index != 1)
                {
                    throw new ArgumentOutOfRangeException("The number should be either 1 or 0");
                }
                else
                {
                    int mask = 1;
                    int position = mask << index;
                    this.Number = (ulong)(position | value);
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int position = 63; position >= 0; position--)
            {
                yield return this[position];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
