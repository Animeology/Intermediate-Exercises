namespace IntermediateExercises.Structures
{
    public class Shape : Location
    {
        protected Location? location;

        public override string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.0;
        }

        public double Perimeter()
        {
            return 0.0;
        }
    }

    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;
    }

    public class Circle : Shape
    {
        protected double radius;
    }

}
