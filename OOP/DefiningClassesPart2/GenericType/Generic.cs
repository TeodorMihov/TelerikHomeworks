namespace GenericType
{
    using System;
    public class Generic<T>
    {
        private T[] elements;

        private int currentPosition;
        private int capacity;

        public Generic(int capacity)
        {
            if (capacity < 2)
            {
                throw new IndexOutOfRangeException("Size must be bigger than 2");
            }

            this.elements = new T[elements];
            this.capacity = capacity;
            this.currentPosition = 0;
        }
    }
}
