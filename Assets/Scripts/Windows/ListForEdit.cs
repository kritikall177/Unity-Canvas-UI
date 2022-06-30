using System.Collections.Generic;
using UnityEngine;

public class ListForEdit : Window
{
    [SerializeField] protected PersonForList PlateOfHuman;
    [SerializeField] protected Transform ContentPosition;

    protected readonly List<PersonForList> ListOfPersons = new List<PersonForList>();

    private void Start()
    {
        for (var i = 0; i < DataBase.ListOfHumans.Count; i++)
        {
            ListOfPersons.Add(Instantiate(PlateOfHuman, ContentPosition));
            ListOfPersons[i].Name.text = DataBase.ListOfHumans[i].Name;
            var j = i;
            var windowParameters = new WindowParameters();
            windowParameters.SetIndex(j);
            windowParameters.SetTypeFrom(DataBase.ListOfHumans[j].GetType());
            ListOfPersons[i].EditButton.button.onClick.AddListener(() =>
            {
                UIManager.Instance.ChangeCurrentWindowOn<EditPerson>(gameObject, windowParameters);
            });
            ListOfPersons[i].DeleteButton.button.onClick.AddListener(() =>
            {
                DataBase.ListOfHumans.RemoveAt(j);
                Destroy(ListOfPersons[j].GameObject);
            });
            ListOfPersons[i].DetailButton.button.onClick.AddListener(() =>
            {
                UIManager.Instance.ChangeCurrentWindowOn<PersonDetail>(gameObject, windowParameters);
            });
        }
    }
}
