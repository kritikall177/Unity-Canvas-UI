using System.Collections.Generic;
using UnityEngine;

public class ListOfAllPersons : Window
{
    [SerializeField] private PersonMainInfo _plateOfHuman;
    [SerializeField] private Transform _contentPosition;

    private readonly List<PersonMainInfo> _listOfPersons = new List<PersonMainInfo>();

    private void Start()
    {
        for (var i = 0; i < DataBase.ListOfHumans.Count; i++)
        {
            _listOfPersons.Add(Instantiate(_plateOfHuman, _contentPosition));
            _listOfPersons[i].SetInfo(DataBase.ListOfHumans[i]);
        }
    }
}
