

Sedan mycar = new Sedan(4, "Blue", true, 4);
mycar.Drive();

RaceCar myracecar = new RaceCar(4, "Red", 400);
myracecar.Drive();




class Vehicle
{
	public int WheelCount;
	public string Color;
	public Vehicle(int _WheelCount, string _Color)
	{
		WheelCount = _WheelCount;
		Color = _Color;
	}
	public virtual void Drive() // virtual means we can override it. 
	{
		Console.WriteLine("I am driving.");
	}
}

class Sedan : Vehicle // ignore the error about constructor parameters 
{
	public bool HasHatchback;
	public int DoorCount;
	public Sedan (int _SedanWheelCount, string _SedanColor, bool _HasHatchback, int _DoorCount) : base(_SedanWheelCount, _SedanColor)
    {
		HasHatchback = _HasHatchback;
		DoorCount = _DoorCount;

    }

    public override void Drive()
    {
        Console.WriteLine("I am driving the speed limit!");
    }

}

class RaceCar : Vehicle
{
	public int EngineSize;

	public RaceCar (int _WheelCount, string _Color, int _EngineSize) 
		: base (_WheelCount, _Color)
    {
		EngineSize = _EngineSize;
    }

    public override void Drive()
    {
        Console.WriteLine("I am driving really fast!");
    }
}