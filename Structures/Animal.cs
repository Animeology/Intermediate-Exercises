namespace IntermediateExercises.Structures
{
    public abstract class Animal
    {
        string m_name = string.Empty;

        public void SetName(string name)
        {
            m_name = name;
        }
        public string GetName()
        {
            return m_name;
        }
        public abstract void Eat();

    }
}
