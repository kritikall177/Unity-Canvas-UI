using UnityEngine.UI;

public class ListForDelete : ListLoad
{
    private void Start()
    {
        LoadingPersonsList();
        for (var i = 0; i < PersonsForEdit.Count; i++)
        {
            var j = i;
            PersonsForEdit[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                DataBase.ListOfHumans.RemoveAt(j);
                Destroy(PersonsForEdit[j]);
            });
        }
    }
}
