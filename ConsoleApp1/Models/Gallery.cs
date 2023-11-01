namespace ConsoleApp1.Models;

internal class Gallery
{
    public string Name { get; set; }
    public Car[] Cars = new Car[0];

    public Car this[int index]
    {
        get
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (i == index)
                {
                    return Cars[i];
                }
            }
            return null;
        }

        set
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (i == index)
                {
                    Cars[index] = value;
                }
            }
        }
    }
    public bool this[string name]
    {
        get
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public void AddCar(Car car)
    {
        Array.Resize(ref Cars, Cars.Length + 1);
        Cars[Cars.Length - 1] = car;
    }

    public void GetAllCars()
    {
        foreach (var car in Cars)
        {
            Console.WriteLine(car);
        }
    }
    
}
