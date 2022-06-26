using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonInputOutput : Window
{
    public List<GameObject> inputFields;
    public List<TextMeshProUGUI> inputFieldsNames;
    public TMP_InputField[] birthday;
    public Button addButton;
    public TextMeshProUGUI outputField;
    protected Person Type;
    protected StartWindow StartWindow;
    protected int IndexInList = -1;
    
    protected void InitialСonfiguration()
    {
        StartWindow = (StartWindow)GetComponentInParent<UIManager>().GetWindow<StartWindow>();
        for (var i = 0; i < 6; i++)
        {
            inputFields[i].SetActive(true);
        }

        inputFieldsNames[0].text = "Name";
        inputFieldsNames[1].text = "Surname";
        inputFieldsNames[2].text = "Patronymic";
        
        switch (Type)
        {
            case Person.Student:
                inputFieldsNames[3].text = "Faculty";
                inputFieldsNames[4].text = "Year";
                inputFieldsNames[5].text = "Group";
                break;
            
            case Person.Employee:
            case Person.Driver:
                inputFieldsNames[3].text = "Organization";
                inputFieldsNames[4].text = "Salary";
                inputFieldsNames[5].text = "Experience";
                if (Type == Person.Driver)
                {
                    for (var i = 6; i < 8; i++)
                    {
                        inputFields[i].SetActive(true);
                        inputFieldsNames[6].text = "Car Brand";
                        inputFieldsNames[7].text = "Car Model";
                    }
                    
                }
                break;
        }
    }

    protected void InputFieldsSetUp()
    {
        for (var i = 0; i < 4; i++)
        {
            inputFields[i].GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.Name;
        }
        
        switch (Type)
        {
            case Person.Student:
                inputFields[4].GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.IntegerNumber;
                inputFields[4].GetComponent<TMP_InputField>().characterLimit = 1;
                inputFields[5].GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.Standard;
                break;
            case Person.Employee:
            case Person.Driver:
                inputFields[4].GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.IntegerNumber;
                inputFields[5].GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.IntegerNumber;
                inputFields[5].GetComponent<TMP_InputField>().characterLimit = 3;
                break;
        }
        foreach (var data in birthday)
        {
            data.contentType = TMP_InputField.ContentType.IntegerNumber;
        }
        birthday[0].characterLimit = 4;
        birthday[1].characterLimit = 2;
        birthday[2].characterLimit = 2;
    }
    
    public void Open(Transform position, Person type)
    {
        Instantiate(this, position).Type = type;
    }
    
    public void Open(Transform position, Person type, int indexInList)
    {
        var window = Instantiate(this, position);
        window.Type = type;
        window.IndexInList = indexInList;
    }
    
    protected void AddingPerson()
    {
        switch (Type)
        {
            case Person.Student:
                var student = gameObject.AddComponent<Student>();
                InputFieldsDevide(out var baseInputFieldsStudent, out var studentInputFields);
                student.InputAdd(baseInputFieldsStudent, birthday, studentInputFields);
                DataBase.List.Add(student);
                break;
            case Person.Employee:
                var employee = gameObject.AddComponent<Employee>();
                InputFieldsDevide(out var baseInputFieldsEmployee, out var employeeInputFields);
                employee.InputAdd(baseInputFieldsEmployee, birthday, employeeInputFields);
                DataBase.List.Add(employee);
                break;
            case Person.Driver:
                var driver = gameObject.AddComponent<Driver>();
                InputFieldsDevide(out var baseInputFieldsDriver, out var driverInputFields,
                    out var driverCarInputFields);
                driver.InputAdd(baseInputFieldsDriver, birthday, driverInputFields,
                    driverCarInputFields);
                DataBase.List.Add(driver);
                break;
        }
    }
    
    protected void LoadPersonInfo()
    {
        switch (DataBase.List[IndexInList].GetType().ToString().StringToPersonEnum())
        {
            case Person.Student:
                var student = (Student)DataBase.List[IndexInList];
                InputFieldsDevide(out var baseInputFieldsStudent, out var studentInputFields);
                student.Print(baseInputFieldsStudent, birthday, studentInputFields);
                break;
            case Person.Employee:
                var employee = (Employee)DataBase.List[IndexInList];
                InputFieldsDevide(out var baseInputFieldsEmployee, out var employeeInputFields);
                employee.Print(baseInputFieldsEmployee, birthday, employeeInputFields);
                break;
            case Person.Driver:
                var driver = (Driver)DataBase.List[IndexInList];
                InputFieldsDevide(out var baseInputFieldsDriver, out var driverInputFields,
                    out var driverCarInputFields);
                driver.Print(baseInputFieldsDriver, birthday, driverInputFields,
                    driverCarInputFields);
                break;
        }
    }
    
    private void InputFieldsDevide(out TMP_InputField[] baseInputFields, out TMP_InputField[] firstPartInputFields)
    {
        var fields = new List<TMP_InputField>();
        foreach (var field in inputFields)
        {
            fields.Add(field.GetComponent<TMP_InputField>());
        }
        baseInputFields = fields.GetRange(0,3).ToArray();
        firstPartInputFields = fields.GetRange(3,3).ToArray();
    }

    private void InputFieldsDevide(out TMP_InputField[] baseInputFields, out TMP_InputField[] firstPartInputFields,
        out TMP_InputField[] secondPartInputFields)
    {
        InputFieldsDevide(out baseInputFields, out firstPartInputFields);
        secondPartInputFields = new[]
        {
            inputFields[inputFields.Count - 2].GetComponent<TMP_InputField>(),
            inputFields[inputFields.Count - 1].GetComponent<TMP_InputField>()
        };
    }
}
