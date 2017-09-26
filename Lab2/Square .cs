namespace Laba2
{
    class Square : Rectangle, IPrint
    {
        public Square(double size)
        : base(size, size)
        {
            Type = "Square";
        }
    }
}
