using System;

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
        }

        public Employee(string name, string surname, string patronymic, DateTime birthday, string organization, int salary, int experience) : base(name, surname, patronymic, birthday)
        {
            Organization = organization;
            Salary = salary;
            Experience = experience;
        }

        public Employee(Employee person) : base(person)
        {
            Organization = person.Organization;
            Salary = person.Salary;
            Experience = person.Experience;
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
        
        public void SetExperience(int experience)
        {
            Experience = experience;
        }

        public void SetExperience(string experience)
        {
            Experience = Convert.ToInt32(experience);
        }
    }
