using System;

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

        public void SetDate(DateTime dateTime)
        {
            Birthday = dateTime;
        }
    }
