// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class Program
{
	public static void Main(string[] args)
	{
		Car car1 = new Car("Opala");
		Car car2 = new Car("Monza");

		Console.WriteLine(Car.numberOfCars);

		Car.StartRace();

		Console.ReadKey();
	}
}

class Car
{
	String Model;

	public static int numberOfCars;

	public Car (string model)
	{
		this.Model = model;
		numberOfCars++;
	}

	public static void StartRace()
	{
		Console.WriteLine("The race has started!!");
	}
}
