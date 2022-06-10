using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditPerson : MonoBehaviour
{
    public int index;
    public void Edit(Human person)
    {
        var inputObjects = new GameObject[4]; 
        for (var i = 0; i < 4; i++)
        {
            inputObjects[i] = transform.GetChild(i).gameObject;
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
        
        if (inputObjects[1].activeSelf)
        {
            var student = (Student)person;
            var studentInputFields = new InputField[inputObjects[1].transform.childCount];
            for (var i = 0; i < inputObjects[1].transform.childCount; i++)
            {
                studentInputFields[i] = inputObjects[1].transform.GetChild(i).GetComponent<InputField>();
            }
            student.Edit(baseInputFields, birthday, studentInputFields);
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
                var driver = (Driver)person;
                driver.Edit(baseInputFields, birthday, employeeInputFields, driverInputFields);
            }
            else
            {
                var employee = (Employee)person;
                employee.Edit(baseInputFields, birthday, employeeInputFields);
            }
        }
    }
}
