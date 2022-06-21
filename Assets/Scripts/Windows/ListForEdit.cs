using UnityEngine.UI;

public class ListForEdit : ListLoad
{
    private EditPerson _editPerson;

    private void Start()
    {
        _editPerson = DataBase.GetWindow<EditPerson>();
        LoadingPersonsList();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeCurrentWindow(_editPerson, DataBase.ListOfHumans[j].TypeOfPerson(), j);
            });
        }
    }
}
