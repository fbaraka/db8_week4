Rectangle Fred = new Rectangle(3.5, 4.2);










class Rectangle
{
    public string Name; 
    public double Length;
    public double Height; 

    public Rectangle(string _Name, double _Length, double _Height)
    {
        Name = _Name;
        Length = _Length;
        Height = _Height;
    }

    public override string ToString()
    {
        return $"{Name}: {Length}x{Height}, Area = {Length*Height}";
    }
}