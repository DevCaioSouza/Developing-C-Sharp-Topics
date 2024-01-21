// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		Car car1 = new Car("Opala", "Black");

		Console.WriteLine("Color..............:{0}", car1.color);
		Console.WriteLine("Name...............:{0}", car1.name);
		Console.WriteLine("Wheels.............:{0}", car1.wheels);
		Console.WriteLine("Max Speed..........:{0}", car1.maxSpeed);
		Console.WriteLine("Is it turned on?...:{0}", car1.getIsOn());
	}
}

public class Vehicle
{
	public int wheels;
	public int maxSpeed;
	public bool on;
	public void turnOn()
	{
		on = true;
	}
	public void turnOff()
	{
		on = false;
	}
	public string getIsOn()
	{
		if (on)
		{
			return "Yes";
		}

		return "No";
	}
}

public class Car : Vehicle
{
	public string name;
	public string color;
	public Car(string name, string color)
	{
		turnOff();
		this.wheels = 4;
		this.maxSpeed = 120;
		this.name = name;
		this.color = color;	
	}

}