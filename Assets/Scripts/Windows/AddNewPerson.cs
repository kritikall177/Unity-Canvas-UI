using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AddNewPerson : Window
{
    public List<Button> buttons;
    private InputPerson _inputPerson;
    
    // Start is called before the first frame update
    void Start()
    {
        _inputPerson = (InputPerson)GetComponentInParent<UIManager>().GetWindow<InputPerson>();
        
        buttons[0].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_inputPerson, Person.Student);
        });
        buttons[1].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_inputPerson, Person.Employee);
        });
        buttons[2].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_inputPerson, Person.Driver);
        });
    }

    protected void ChangeCurrentWindow(InputPerson sender, Person type)
    {
        sender.Open(transform.parent, type);
        Close();
    }
}
