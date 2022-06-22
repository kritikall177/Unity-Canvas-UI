using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListForDelete : ListLoad
{
    // Start is called before the first frame update
    void Start()
    {
        LoadingPersonslist();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                DataBase.List.RemoveAt(j);
                Destroy(PersonsForEdit[j]);
            });
        }
    }
}
