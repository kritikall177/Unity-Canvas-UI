using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Employee : Human
    {
        public string Organization { get; protected set; }
        public int Salary { get; protected set; }
        public byte Experience { get; protected set; }

        public Employee()
        {
            Organization = null;
            Salary = 0;
            Experience = 0;
            Console.WriteLine("Employee has been created");
        }

        public Employee(string name, string surname, string patronymic, DateTime birthday, string organization, int salary, byte experience) : base(name, surname, patronymic, birthday)
        {
            Organization = organization;
            Salary = salary;
            Experience = experience;
            Console.WriteLine("Employee has been created");
        }

        public Employee(Employee person) : base(person)
        {
            Organization = person.Organization;
            Salary = person.Salary;
            Experience = person.Experience;
            Console.WriteLine("Employee has been cloned");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Organization: {Organization}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Experience: {Experience}");
        }

        public void SetOrganization(string organization)
        {
            Organization = organization;
        }
        
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
        
        public void SetSalary(string salary)
        {
            Salary = Convert.ToInt32(salary);
        }
        
        public void SetExperience(byte experience)
        {
            Experience = experience;
        }
        
        public void SetExperience(string experience)
        {
            Experience = Convert.ToByte(experience);
        }
        
        public void InputAdd(InputField[] baseInputFields, InputField[] birthday, InputField[] employeeInputFields)
        {
            base.InputAdd(baseInputFields, birthday);
            SetOrganization(employeeInputFields[0].text);
            SetSalary(employeeInputFields[1].text);
            SetExperience(employeeInputFields[2].text);
        }
    }
