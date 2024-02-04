namespace TemplateMethod
{
    public struct Vector
    {
        public float X;
        public float Y;
        public float Z;        

        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector Front
        {
            get
            {
                // Generates a vector points to front
                return new Vector(0, 0, float.MaxValue);
            }
        }
    }
}
