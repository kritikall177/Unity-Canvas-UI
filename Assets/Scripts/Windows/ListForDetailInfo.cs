using UnityEngine.UI;

public class ListForDetailInfo : ListLoad
{
    private PersonDetail _personDetail;

    private void Start()
    {
        _personDetail = DataBase.GetWindow<PersonDetail>();
        LoadingPersonsList();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeCurrentWindow(_personDetail, DataBase.ListOfHumans[j].TypeOfPerson(), j);
            });
        }
    }
}
