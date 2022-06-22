using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListForEdit : ListLoad
{
    private EditPerson _editPerson;

    // Start is called before the first frame update
    void Start()
    {
        _editPerson = (EditPerson)GetComponentInParent<UIManager>().GetWindow<EditPerson>();
        LoadingPersonslist();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeCurrentWindow(_editPerson, DataBase.List[j].GetType().ToString().StringToPersonEnum(), j);
            });
        }
    }
    
    private void ChangeCurrentWindow(EditPerson sender, Person type, int indexInList)
    {
        sender.Open(transform.parent, type, indexInList);
        Close();
    }
}
