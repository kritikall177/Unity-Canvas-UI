using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class Driver : Employee
    {
        private string CarBrand { get; set; }
        private string CarModel { get; set; }

        public Driver()
        {
            CarBrand = null;
            CarModel = null;
            Console.WriteLine("Driver has been created");
        }

        public Driver(string name, string surname, string patronymic, DateTime birthday, string organization, int salary, byte experience, string carBrand, string carModel) : base(name, surname, patronymic, birthday, organization, salary, experience)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            Console.WriteLine("Driver has been created");
        }

        public Driver(Driver person) : base(person)
        {
            CarBrand = person.CarBrand;
            CarModel = person.CarModel;
            Console.WriteLine("Driver has been cloned");
        }

        ~Driver()
        {
            Console.WriteLine("Driver has been deleted");
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Car Brand: {CarBrand}");
            Console.WriteLine($"Car Model: {CarModel}");
        }

        public void SetCarBrand(string brand)
        {
            CarBrand = brand;
        }

        public void SetCarModel(string model)
        {
            CarModel = model;
        }
        
        public void InputAdd(InputField[] baseInputFields, InputField[] birthday, InputField[] employeeInputFields, InputField[] driverInputFields)
        {
            base.InputAdd(baseInputFields, birthday, employeeInputFields);
            SetCarBrand(driverInputFields[0].text);
            SetCarModel(driverInputFields[1].text);
        }
        
        public void Edit(InputField[] baseInputFields, InputField[] birthday, InputField[] employeeInputFields, InputField[] driverInputFields)
        {
            base.Edit(baseInputFields, birthday, employeeInputFields);
            driverInputFields[0].text = CarBrand;
            driverInputFields[1].text = CarModel;
        }
        
        public void Print(Text[] baseInputFields, Text[] birthday, Text[] employeeInputFields, Text[] driverInputFields)
        {
            base.Print(baseInputFields, birthday, employeeInputFields);
            driverInputFields[0].text = CarBrand;
            driverInputFields[1].text = CarModel;
        }
    }
