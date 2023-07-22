namespace IntermediateExercises.GenericCollections
{
    public class QueuePosition
    {
        int[] queue;
        int currentPos;


        public QueuePosition(int queueSize)
        {
            queue = new int[queueSize];
            currentPos = -1;
        }

        public void Enqueue(int value)
        {
            currentPos++;
            queue[currentPos] = value;
        }

        public int DeQueue()
        {
            int removedValue = queue[0];

            for(int i = 0; i < currentPos; i++)
            {
                queue[i] = queue[i + 1];
            }

            queue[currentPos] = removedValue;
            currentPos--;

            return queue[currentPos + 1];
        }
    }
}
