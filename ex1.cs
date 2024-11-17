using System; 

namespace ConsoleApp11
{
    internal struct Vector
    {
        public double x {  get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x+b.x, a.y+b.y, a.z+b.z);
        }
        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static Vector operator *(Vector a, double ch)
        {
            return new Vector(a.x * ch, a.y * ch, a.z * ch);
        }
        public static Vector operator *(double ch, Vector a)
        {
            return a*ch;
        }
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public static bool operator <(Vector a, Vector b)
        {
            return a.Length() < b.Length();
        }
        public static bool operator >(Vector a, Vector b)
        {
            return a.Length() > b.Length();
        }
        public static bool operator <=(Vector a, Vector b)
        {
            return a.Length() <= b.Length();
        }
        public static bool operator >=(Vector a, Vector b)
        {
            return a.Length() >= b.Length();
        }
        public static bool operator ==(Vector a, Vector b)
        {
            return a.Length() == b.Length();
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return a.Length() != b.Length();
        }
    }
}
