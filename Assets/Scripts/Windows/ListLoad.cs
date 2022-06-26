using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListLoad : Window
{
    public GameObject button;
    public Transform contentPosition;
    protected List<GameObject> PersonsForEdit = new List<GameObject>();
    
    protected void LoadingPersonslist()
    {
        for (var i = 0; i < DataBase.List.Count; i++)
        {
            PersonsForEdit.Add(Instantiate(button, contentPosition));
            PersonsForEdit[i].transform.GetComponent<ButtonController>().NameOnButton.text = DataBase.List[i].Name;
        }
    }
}
