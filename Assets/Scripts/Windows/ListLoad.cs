using System.Collections.Generic;
using UnityEngine;

public class ListLoad : Window
{
    [SerializeField] protected GameObject PlateOfHuman;
    [SerializeField] protected Transform ContentPosition;
    
    protected readonly List<GameObject> PersonsForEdit = new List<GameObject>();

    protected void LoadingPersonsList()
    {
        for (var i = 0; i < DataBase.ListOfHumans.Count; i++)
        {
            PersonsForEdit.Add(Instantiate(PlateOfHuman, ContentPosition));
            PersonsForEdit[i].transform.GetComponent<ButtonController>().NameOnButton.text =
                DataBase.ListOfHumans[i].Name;
        }
    }

    protected void ChangeCurrentWindow(PersonInputOutput sender, Person type, int indexInList)
    {
        sender.Open(transform.parent, type, indexInList);
        Close();
    }
}
