using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartWindow : Window
{
    [SerializeField] private Button _addNewPerson;
    [SerializeField] private Button _listForEdit;
    [SerializeField] private Button _listForDelete;
    [SerializeField] private Button _listForDetailInfo;
    [SerializeField] private Button _listOfAllPersons;

    private void Start()
    {
        _addNewPerson.onClick.AddListener(() => { ChangeCurrentWindow(DataBase.GetWindow<AddNewPerson>()); });
        _listForEdit.onClick.AddListener(() => { ChangeCurrentWindow(DataBase.GetWindow<ListForEdit>()); });
        _listForDelete.onClick.AddListener(() => { ChangeCurrentWindow(DataBase.GetWindow<ListForDelete>()); });
        _listForDetailInfo.onClick.AddListener(() => { ChangeCurrentWindow(DataBase.GetWindow<ListForDetailInfo>()); });
        _listOfAllPersons.onClick.AddListener(() => { ChangeCurrentWindow(DataBase.GetWindow<ListOfAllPersons>()); });
    }
}
