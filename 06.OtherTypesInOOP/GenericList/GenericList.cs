namespace GenericList
{
    public class GenericList<T>
    {
        private const int DefaultCapacity = 16;

        private int[] elements;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new int[capacity];
        }

        public void AddElement(T element)
        {

        }

        public int this[int index]
        {
            get
            {
                return this.elements[index];
            }
            //set
            //{
            //    int number;
            //    if (int.TryParse(value.ToString(), out number) == false)
            //    {
            //        throw new FormatException("Invalid number.");
            //    }
            //    this.elements[index] = value;
            //}
        }

        public void RemoveElement(int index)
        {

        }

        public void InsertElement(int index)
        {

        }

        public void Clear()
        {

        }

        public int FindElementIndex(int element)
        {
            return 1;
        }

        public bool Contains(int element)
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
