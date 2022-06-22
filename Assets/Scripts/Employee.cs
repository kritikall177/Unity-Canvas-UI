using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Employee : Human
    {
        public string Organization { get; protected set; }
        public int Salary { get; protected set; }
        public int Experience { get; protected set; }

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
            Experience = Convert.ToInt32(experience);
        }
        
        public void InputAdd(InputField[] baseInputFields, InputField[] birthday, InputField[] employeeInputFields)
        {
            base.InputAdd(baseInputFields, birthday);
            InputFieldChecker(employeeInputFields);
            SetOrganization(employeeInputFields[0].text);
            SetSalary(employeeInputFields[1].text);
            SetExperience(employeeInputFields[2].text);
        }
        
        public void Print(InputField[] baseInputFields, InputField[] birthday, InputField[] employeeInputFields)
        {
            base.Print(baseInputFields, birthday);
            employeeInputFields[0].text = Organization;
            employeeInputFields[1].text = Convert.ToString(Salary);
            employeeInputFields[2].text = Convert.ToString(Experience);
        }
        
        public void PrintBase(Text[] baseInputFields, Text[] birthday, Text[] employeeInputFields)
        {
            base.PrintBase(baseInputFields, birthday);
            employeeInputFields[0].text = Organization;
            employeeInputFields[1].text = Convert.ToString(Salary);
            employeeInputFields[2].text = Convert.ToString(Experience);
        }
    }
