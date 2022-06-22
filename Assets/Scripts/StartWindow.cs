using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartWindow : Window
{
    public List<Button> buttons;
    private AddNewPerson _addNewPerson;
    private ListForEdit _listForEdit;
    private ListForDelete _listForDelete;
    private ListForDetailInfo _listForDetailInfo;
    private ShowAllPersons _showAllPersons;
    
    void Start()
    {
        _addNewPerson = (AddNewPerson)GetComponentInParent<UIManager>().GetWindow<AddNewPerson>();
        _listForEdit = (ListForEdit)GetComponentInParent<UIManager>().GetWindow<ListForEdit>();
        _listForDelete = (ListForDelete)GetComponentInParent<UIManager>().GetWindow<ListForDelete>();
        _listForDetailInfo = (ListForDetailInfo)GetComponentInParent<UIManager>().GetWindow<ListForDetailInfo>();
        _showAllPersons = (ShowAllPersons)GetComponentInParent<UIManager>().GetWindow<ShowAllPersons>();
        
        buttons[0].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_addNewPerson);
        });
        buttons[1].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_listForEdit);
        });
        buttons[2].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_listForDelete);
        });
        buttons[3].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_listForDetailInfo);
        });
        buttons[4].onClick.AddListener(() =>
        {
            ChangeCurrentWindow(_showAllPersons);
        });
    }
}
