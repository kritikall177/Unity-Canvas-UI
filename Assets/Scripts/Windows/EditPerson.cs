using System;

public class EditPerson : PersonInputOutput
{
    private void Start()
    {
        addButton.onClick.AddListener(() =>
        {
            try
            {
                AddingPerson();
                DataBase.ListOfHumans.RemoveAt(IndexInList);
                ChangeCurrentWindow(StartWindow);
            }
            catch (Exception exception)
            {
                outputField.text = exception.Message;
            }
        });
        InitialConfiguration();
        InputFieldsSetUp();
        addButton.transform.GetComponent<ButtonController>().NameOnButton.text = "Edit";
        LoadPersonInfo();
    }
}
