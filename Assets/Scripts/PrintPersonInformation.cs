using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintPersonInformation : MonoBehaviour
{
    public int index;

    public void PrintDetail(Human person)
    {
        var inputObjects = new GameObject[4]; 
        for (var i = 0; i < 4; i++)
        {
            inputObjects[i] = transform.GetChild(i).gameObject;
        }
        
        var baseInputFields = new Text[inputObjects[0].transform.childCount - 1];
        for (var i = 0; i < inputObjects[0].transform.childCount - 1; i++)
        {
            baseInputFields[i] = inputObjects[0].transform.GetChild(i).transform.GetChild(0).GetComponent<Text>();
        }

        var birthday = new Text[3];
        for (var i = 0; i < 3; i++)
        {
            birthday[i] = inputObjects[0].transform.GetChild(3).transform.GetChild(i).transform.GetChild(0).GetComponent<Text>();
        }
        
        if (inputObjects[1].activeSelf)
        {
            var student = (Student)person;
            var studentInputFields = new Text[inputObjects[1].transform.childCount];
            for (var i = 0; i < inputObjects[1].transform.childCount; i++)
            {
                studentInputFields[i] = inputObjects[1].transform.GetChild(i).transform.GetChild(0).GetComponent<Text>();
            }
            student.Print(baseInputFields, birthday, studentInputFields);
        }
        else if (inputObjects[2].activeSelf)
        {
            var employeeInputFields = new Text[inputObjects[2].transform.childCount];
            for (var i = 0; i < inputObjects[2].transform.childCount; i++)
            {
                employeeInputFields[i] = inputObjects[2].transform.GetChild(i).transform.GetChild(0).GetComponent<Text>();
            }

            if (inputObjects[3].activeSelf)
            {
                var driverInputFields = new Text[inputObjects[3].transform.childCount];
                for (var i = 0; i < inputObjects[3].transform.childCount; i++)
                {
                    driverInputFields[i] = inputObjects[3].transform.GetChild(i).transform.GetChild(0).GetComponent<Text>();
                }
                var driver = (Driver)person;
                driver.Print(baseInputFields, birthday, employeeInputFields, driverInputFields);
            }
            else
            {
                var employee = (Employee)person;
                employee.Print(baseInputFields, birthday, employeeInputFields);
            }
        }
    }
}
