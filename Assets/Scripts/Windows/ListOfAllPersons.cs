public class ListOfAllPersons : ListLoad
{
    private void Start()
    {
        for (var i = 0; i < DataBase.ListOfHumans.Count; i++)
        {
            PersonsForEdit.Add(Instantiate(PlateOfHuman, ContentPosition));
            DataBase.ListOfHumans[i].PrintBase(PersonsForEdit[i].GetComponent<PersonMainInfo>().baseInfo,
                PersonsForEdit[i].GetComponent<PersonMainInfo>().birthday);
        } 
    }
}
