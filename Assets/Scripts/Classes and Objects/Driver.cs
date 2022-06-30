using System;

public sealed class Driver : Employee
{
    public string CarBrand { get; private set; }
    public string CarModel { get; private set; }

    public Driver()
    {
        CarBrand = null;
        CarModel = null;
    }

    public Driver(string name, string surname, string patronymic, DateTime birthday, string organization, int salary,
        int experience, string carBrand, string carModel) : base(name, surname, patronymic, birthday, organization,
        salary, experience)
    {
        CarBrand = carBrand;
        CarModel = carModel;
    }

    public Driver(Driver person) : base(person)
    {
        CarBrand = person.CarBrand;
        CarModel = person.CarModel;
    }

    public void SetCarBrand(string brand)
    {
        CarBrand = brand;
    }

    public void SetCarModel(string model)
    {
        CarModel = model;
    }
}