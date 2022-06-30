using System;

public class Student : Human
    {
        public string Faculty { get; protected set; }
        public int Year { get; protected set; }
        public string Group { get; protected set; }

        public Student()
        {
            Faculty = null;
            Year = 0;
            Group = null;
        }

        public Student(string name, string surname, string patronymic, DateTime birthday, string faculty, int year, string group) : base(name, surname, patronymic, birthday)
        {
            Faculty = faculty;
            Year = year;
            Group = group;
        }

        public Student(Student person) : base(person)
        {
            Faculty = person.Faculty;
            Year = person.Year;
            Group = person.Group;
        }

        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }

        public void SetYear(int year)
        {
            Year = year;
        }
        
        public void SetYear(string year)
        {
            Year = Convert.ToInt32(year);
        }

        public void SetGroup(string group)
        {
            Group = group;
        }
    }
