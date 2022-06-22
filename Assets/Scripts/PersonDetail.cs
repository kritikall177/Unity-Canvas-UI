using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PersonDetail : PersonInputOutput
{
    // Start is called before the first frame update
    void Start()
    {
        addButton.onClick.AddListener(() =>
        {
            ChangeCurrentWindow(StartWindow);
        });
        InitialСonfiguration();
        addButton.transform.GetComponent<ButtonController>().NameOnButton.text = "Back";
        InputFieldsSetUp();
        LoadPersonInfo();
        PlaceHolderDisable();

    }

    private void PlaceHolderDisable()
    {
        foreach (var inputField in inputFields)
        {
            inputField.GetComponent<InputField>().enabled = false;
        }

        foreach (var inputField in birthday)
        {
            inputField.enabled = false;
        }
    }
}
