using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EditPerson : PersonInputOutput
{
    void Start()
    {
        addButton.onClick.AddListener(() =>
        {
            try
            {
                AddingPerson();
                DataBase.List.RemoveAt(IndexInList);
                ChangeCurrentWindow(StartWindow);
            }
            catch (Exception exception)
            {
                outputField.text = exception.Message;
            }
        });
        InitialСonfiguration();
        InputFieldsSetUp();
        addButton.transform.GetComponent<ButtonController>().NameOnButton.text = "Edit";
        LoadPersonInfo();
    }
}
