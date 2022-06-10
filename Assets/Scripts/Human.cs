using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Human : MonoBehaviour
    {
        public string Name { get; protected set; }

        public string Surname { get; protected set; }

        public string Patronymic { get; protected set; }

        public DateTime Birthday { get; protected set; }

        protected Human()
        {
            Name = null;
            Surname = null;
            Patronymic = null;
            Birthday = new DateTime();
        }

        protected Human(string name, string surname, string patronymic, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
        }
        
        protected Human(Human person)
        {
            Name = person.Name;
            Surname = person.Surname;
            Patronymic = person.Patronymic;
            Birthday = person.Birthday;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Patronymic: {Patronymic}");
            Console.WriteLine($"Birthday: {Birthday.ToShortDateString()}");
        }

        public void PrintFullYears()
        {
            Console.WriteLine($"Full years: {(int)((DateTime.Today - Birthday).TotalDays / 365.2425)}");
        }

        public void SetName(string name)
        {
            Name = name;
        }
        
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        
        public void SetPatronymic(string patronymic)
        {
            Patronymic = patronymic;
        }
        
        public void SetDate(string year, string month, string day)
        {
            Birthday = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
        }
        
        public void SetDate(DateTime dateTime)
        {
            Birthday = dateTime;
        }

        public void InputAdd(InputField[] baseInputFields, InputField[] birthday)
        {
            SetName(baseInputFields[0].text);
            SetSurname(baseInputFields[1].text);
            SetPatronymic(baseInputFields[2].text);
            SetDate(birthday[0].text, birthday[1].text, birthday[2].text);
        }

        public void Edit(InputField[] baseInputFields, InputField[] birthday)
        {
            baseInputFields[0].text = Name;
            baseInputFields[1].text = Surname;
            baseInputFields[2].text = Patronymic;
            birthday[0].text = Convert.ToString(Birthday.Year);
            birthday[1].text = Convert.ToString(Birthday.Month);
            birthday[2].text = Convert.ToString(Birthday.Day);
        }

        public void Print(Text[] baseInputFields, Text[] birthday)
        {
            baseInputFields[0].text = Name;
            baseInputFields[1].text = Surname;
            baseInputFields[2].text = Patronymic;
            birthday[0].text = Convert.ToString(Birthday.Year);
            birthday[1].text = Convert.ToString(Birthday.Month);
            birthday[2].text = Convert.ToString(Birthday.Day);
        }
        
    }
