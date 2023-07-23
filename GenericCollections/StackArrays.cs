namespace IntermediateExercises.GenericCollections
{
    public class StackArrays
    {
        int[] intArr;
        int currentPos;

        public StackArrays(int size)
        {
            intArr = new int[size];
            currentPos = -1;
        }

        public void Push(int value)
        {
            currentPos++;
            intArr[currentPos] = value;
        }

        public int Pop()
        {
            if(currentPos > 0)
            {
                currentPos -= 1;
                return intArr[currentPos];
            }
            return 0;
        }
    }
}
