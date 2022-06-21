using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.String;

public abstract class Human
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
            if (Convert.ToInt32(year) <= 0 || Convert.ToInt32(year) > DateTime.Now.Year ||
                Convert.ToInt32(month) > 12 || Convert.ToInt32(month) < 1 || Convert.ToInt32(day) > 31 ||
                Convert.ToInt32(day) < 1)
            {
                throw new Exception("Invalid date input");
            }
            Birthday = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
        }
        
        public void SetDate(DateTime dateTime)
        {
            Birthday = dateTime;
        }

        public void InputAdd(TMP_InputField[] baseInputFields, TMP_InputField[] birthday)
        {
            InputFieldChecker(baseInputFields);
            SetName(baseInputFields[0].text);
            SetSurname(baseInputFields[1].text);
            SetPatronymic(baseInputFields[2].text);
            SetDate(birthday[0].text, birthday[1].text, birthday[2].text);
        }

        public void Print(TMP_InputField[] baseInputFields, TMP_InputField[] birthday)
        {
            baseInputFields[0].text = Name;
            baseInputFields[1].text = Surname;
            baseInputFields[2].text = Patronymic;
            birthday[0].text = Convert.ToString(Birthday.Year);
            birthday[1].text = Convert.ToString(Birthday.Month);
            birthday[2].text = Convert.ToString(Birthday.Day);
        }

        public void PrintBase(TextMeshProUGUI[] baseFields, TextMeshProUGUI[] birthday)
        {
            baseFields[0].text = Name;
            baseFields[1].text = Surname;
            baseFields[2].text = Patronymic;
            birthday[0].text = Convert.ToString(Birthday.Year);
            birthday[1].text = Convert.ToString(Birthday.Month);
            birthday[2].text = Convert.ToString(Birthday.Day);
        }

        protected void InputFieldChecker(TMP_InputField[] fields)
        {
            foreach (var str in fields)
            {
                if (IsNullOrEmpty(str.text))
                {
                    throw new Exception("All fields must be specified");
                }
                if (int.TryParse(str.text, out var result))
                {
                    if (result < 0)
                    {
                        throw new Exception("Invalid digits input"); 
                    }
                }
            }
        }
        
    }
