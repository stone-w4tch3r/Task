namespace Task
{
    public class MyStack
    {
        private int count;
        private Element last;

        public int Count => count;
        public bool IsEmpty => count == 0; 

        public MyStack() 
        {
            count = 0;
            last = null;
        }

        public void Push(ValueType value) 
        {
            count++;

            last = new Element (last, value);
        }

        public ValueType Pop() 
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack Is Already Empty!");      
            }

            var value = last.Value;
            count--;
            last = last.Previous;

            return value;
        }

        public void Clear()
        {
            count = 0;
            last = null;
        }
    }

    public class Element
    {
        public Element Previous { get; }
        public ValueType Value { get; }

        public Element (Element previous, ValueType value) 
        {
            Previous = previous;
            Value = value;
        }

    }

    public class Test //code from interview
    {

    }
}