using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListOfAllPersons : ListLoad
{
    void Start()
    {
        for (var i = 0; i < DataBase.List.Count; i++)
        {
            PersonsForEdit.Add(Instantiate(button, contentPosition));
            DataBase.List[i].PrintBase(PersonsForEdit[i].GetComponent<PersonMainInfo>().baseInfo,
                PersonsForEdit[i].GetComponent<PersonMainInfo>().birthday);
        } 
    }
}
