using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InputPerson : PersonInputOutput
{
    void Start()
    {
        addButton.onClick.AddListener(() =>
        {
            try
            {
                AddingPerson();
                ChangeCurrentWindow(StartWindow);
            }
            catch (Exception exception)
            {
                outputField.text = exception.Message;
            }
        });
        InitialСonfiguration();
        InputFieldsSetUp();
    }
}
