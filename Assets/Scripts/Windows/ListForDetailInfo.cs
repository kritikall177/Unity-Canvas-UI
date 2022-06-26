using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListForDetailInfo : ListLoad
{
    private PersonDetail _personDetail;
    // Start is called before the first frame update
    void Start()
    {
        _personDetail = (PersonDetail)GetComponentInParent<UIManager>().GetWindow<PersonDetail>();
        LoadingPersonslist();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeCurrentWindow(_personDetail, DataBase.List[j].GetType().ToString().StringToPersonEnum(), j);
            });
        }
    }

    private void ChangeCurrentWindow(PersonDetail sender, Person type, int indexInList)
    {
        sender.Open(transform.parent, type, indexInList);
        Close();
    }
}
