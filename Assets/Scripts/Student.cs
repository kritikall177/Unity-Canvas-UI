using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Student : Human
    {
        public string Faculty { get; protected set; }
        public byte Year { get; protected set; }
        public string Group { get; protected set; }

        public Student()
        {
            Faculty = null;
            Year = 0;
            Group = null;
            Console.WriteLine("Student has been created");
        }

        public Student(string name, string surname, string patronymic, DateTime birthday, string faculty, byte year, string group) : base(name, surname, patronymic, birthday)
        {
            Faculty = faculty;
            Year = year;
            Group = group;
            Console.WriteLine("Student has been created");
        }

        public Student(Student person) : base(person)
        {
            Faculty = person.Faculty;
            Year = person.Year;
            Group = person.Group;
            Console.WriteLine("Student has been cloned");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Group: {Group}");
        }

        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }

        public void SetYear(byte year)
        {
            Year = year;
        }
        
        public void SetYear(string year)
        {
            Year = Convert.ToByte(year);
        }

        public void SetGroup(string group)
        {
            Group = group;
        }

        public void InputAdd(InputField[] baseInputFields, InputField[] birthday, InputField[] studentInputFields)
        {
            base.InputAdd(baseInputFields, birthday);
            SetFaculty(studentInputFields[0].text);
            SetYear(studentInputFields[1].text);
            SetGroup(studentInputFields[2].text);
        }
        
        public void Edit(InputField[] baseInputFields, InputField[] birthday, InputField[] studentInputFields)
        {
            base.Edit(baseInputFields, birthday);
            studentInputFields[0].text = Faculty;
            studentInputFields[1].text = Convert.ToString(Year);
            studentInputFields[2].text = Group;
        }
        
        public void Print(Text[] baseInputFields, Text[] birthday, Text[] studentInputFields)
        {
            base.Print(baseInputFields, birthday);
            studentInputFields[0].text = Faculty;
            studentInputFields[1].text = Convert.ToString(Year);
            studentInputFields[2].text = Group;
        }
        
    }
