using System;
using TMPro;
using UnityEngine;

public class PersonInputOutput : Window
{
    [SerializeField] protected InputFieldPrefab Name;
    [SerializeField] protected InputFieldPrefab Surname;
    [SerializeField] protected InputFieldPrefab Patronymic;

    [SerializeField] protected InputFieldPrefab Faculty;
    [SerializeField] protected InputFieldPrefab Year;
    [SerializeField] protected InputFieldPrefab Group;

    [SerializeField] protected InputFieldPrefab Organization;
    [SerializeField] protected InputFieldPrefab Salary;
    [SerializeField] protected InputFieldPrefab Experience;

    [SerializeField] protected InputFieldPrefab CarBrand;
    [SerializeField] protected InputFieldPrefab CarModel;

    [SerializeField] protected InputFieldBirthday _birthday;
    [SerializeField] protected TextMeshProUGUI OutputField;
    [SerializeField] protected ButtonController CompletionButton;

    protected virtual void Start()
    {
        Name.SetParameters("Name", TMP_InputField.ContentType.Name);
        Surname.SetParameters("Surname", TMP_InputField.ContentType.Name);
        Patronymic.SetParameters("Patronymic", TMP_InputField.ContentType.Name);
        _birthday.SetActive(true);

        switch (WindowParameters.Type.Name)
        {
            case nameof(Student):
                Faculty.SetParameters("Faculty", TMP_InputField.ContentType.Name);
                Year.SetParameters("Year", TMP_InputField.ContentType.IntegerNumber, 1);
                Group.SetParameters("Group", TMP_InputField.ContentType.Standard);
                break;
            case nameof(Driver):
                CarBrand.SetParameters("Car Brand", TMP_InputField.ContentType.Standard);
                CarModel.SetParameters("Car Model", TMP_InputField.ContentType.Standard);
                goto case nameof(Employee);
            case nameof(Employee):
                Organization.SetParameters("Organization", TMP_InputField.ContentType.Standard);
                Salary.SetParameters("Salary", TMP_InputField.ContentType.IntegerNumber);
                Experience.SetParameters("Experience", TMP_InputField.ContentType.IntegerNumber, 100);
                break;
        }
    }

    protected void AddAPerson()
    {
        switch (WindowParameters.Type.Name)
        {
            case nameof(Student):
                DataBase.ListOfHumans.Add(new Student(Name.inputField.text, Surname.inputField.text,
                    Patronymic.inputField.text, _birthday.GetDateTime(), Faculty.inputField.text,
                    Convert.ToInt32(Year.inputField.text), Group.inputField.text));
                break;
            case nameof(Employee):
                DataBase.ListOfHumans.Add(new Employee(Name.inputField.text, Surname.inputField.text,
                    Patronymic.inputField.text, _birthday.GetDateTime(), Organization.inputField.text,
                    Convert.ToInt32(Salary.inputField.text), Convert.ToInt32(Experience.inputField.text)));
                break;
            case nameof(Driver):
                DataBase.ListOfHumans.Add(new Driver(Name.inputField.text, Surname.inputField.text,
                    Patronymic.inputField.text, _birthday.GetDateTime(), Organization.inputField.text,
                    Convert.ToInt32(Salary.inputField.text), Convert.ToInt32(Experience.inputField.text),
                    CarBrand.inputField.text, CarModel.inputField.text));
                break;
        }
    }

    protected void LoadPersonInfo()
    {
        var human = DataBase.ListOfHumans[WindowParameters.IndexInList];
        Name.inputField.text = human.Name;
        Surname.inputField.text = human.Surname;
        Patronymic.inputField.text = human.Patronymic;
        _birthday.SetDateTime(human.Birthday);

        switch (human.GetType().Name)
        {
            case nameof(Student):
                var student = (Student)human;
                Faculty.inputField.text = student.Faculty;
                Year.inputField.text = Convert.ToString(student.Year);
                Group.inputField.text = student.Group;
                break;
            case nameof(Driver):
                var driver = (Driver)human;
                CarBrand.inputField.text = driver.CarBrand;
                CarModel.inputField.text = driver.CarModel;
                goto case nameof(Employee);
            case nameof(Employee):
                var employee = (Employee)human;
                Organization.inputField.text = employee.Organization;
                Salary.inputField.text = Convert.ToString(employee.Salary);
                Experience.inputField.text = Convert.ToString(employee.Experience);
                break;
        }
    }
}