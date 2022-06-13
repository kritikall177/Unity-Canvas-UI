using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPerson : MonoBehaviour
{
    public void AddingPerson(GameObject windowAfterComplete)
    {
        var inputObjects = new GameObject[4]; 
        for (var i = 0; i < 4; i++)
        {
            inputObjects[i] = transform.parent.gameObject.transform.GetChild(i).gameObject;
        }

        var baseInputFields = new InputField[inputObjects[0].transform.childCount - 1];
        for (var i = 0; i < inputObjects[0].transform.childCount - 1; i++)
        {
            baseInputFields[i] = inputObjects[0].transform.GetChild(i).GetComponent<InputField>();
        }

        var birthday = new InputField[3];
        for (var i = 0; i < 3; i++)
        {
            birthday[i] = inputObjects[0].transform.GetChild(3).transform.GetChild(i).GetComponent<InputField>();
        }

        try
        {
            if (inputObjects[1].activeSelf)
            {
                var student = gameObject.AddComponent<Student>();
                var studentInputFields = new InputField[inputObjects[1].transform.childCount];
                for (var i = 0; i < inputObjects[1].transform.childCount; i++)
                {
                    studentInputFields[i] = inputObjects[1].transform.GetChild(i).GetComponent<InputField>();
                }
                student.InputAdd(baseInputFields, birthday, studentInputFields);
                ManagerUI.List.Add(student);
            }
            else if (inputObjects[2].activeSelf)
            {
                var employeeInputFields = new InputField[inputObjects[2].transform.childCount];
                for (var i = 0; i < inputObjects[2].transform.childCount; i++)
                {
                    employeeInputFields[i] = inputObjects[2].transform.GetChild(i).GetComponent<InputField>();
                }

                if (inputObjects[3].activeSelf)
                {
                    var driverInputFields = new InputField[inputObjects[3].transform.childCount];
                    for (var i = 0; i < inputObjects[3].transform.childCount; i++)
                    {
                        driverInputFields[i] = inputObjects[3].transform.GetChild(i).GetComponent<InputField>();
                    }
                    var driver = gameObject.AddComponent<Driver>();
                    driver.InputAdd(baseInputFields, birthday, employeeInputFields, driverInputFields);
                    ManagerUI.List.Add(driver);
                }
                else
                {
                    var employee = gameObject.AddComponent<Employee>();
                    employee.InputAdd(baseInputFields, birthday, employeeInputFields);
                    ManagerUI.List.Add(employee);
                }
            }
            GetComponent<ButtonController>().CreateWindow(windowAfterComplete);
        }
        catch (Exception exception)
        {
            transform.parent.GetChild(transform.parent.childCount - 1).GetChild(0).GetComponent<Text>().text =
                exception.Message;
        }
    }

    public void RewritePerson(GameObject windowAfterComplete)
    {
        var index = transform.parent.GetComponent<EditPerson>().index;
        AddingPerson(windowAfterComplete);
        ManagerUI.List.RemoveAt(index);
    }
}
