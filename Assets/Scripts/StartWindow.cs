using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartWindow : Window
{
    public List<GameObject> buttons;
    private AddNewPerson addNewPerson;
    private EditPerson editPerson;
    private DeletePerson deletePerson;
    private PersonDetail personDetail;
    private ShowAllPersons showAllPersons;
    
    void Start()
    {
        addNewPerson = (AddNewPerson)GetComponentInParent<UIManager>().GetWindow<AddNewPerson>();
        editPerson = (EditPerson)GetComponentInParent<UIManager>().GetWindow<EditPerson>();
        deletePerson = (DeletePerson)GetComponentInParent<UIManager>().GetWindow<DeletePerson>();
        personDetail = (PersonDetail)GetComponentInParent<UIManager>().GetWindow<PersonDetail>();
        showAllPersons = (ShowAllPersons)GetComponentInParent<UIManager>().GetWindow<ShowAllPersons>();
        
        buttons[0].GetComponent<Button>().onClick.AddListener(() =>
        {
            ChangeCurrentWindow(addNewPerson);
        });
    }
    
    protected override void SelfOpen(Transform position)
    {
        Instantiate(this, position);
    }

    protected override void SelfClose()
    {
        Destroy(gameObject);
    }
}
