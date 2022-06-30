using System;

public class EditPerson : PersonInputOutput
{
    protected override void Start()
    {
        base.Start();
        CompletionButton.button.onClick.AddListener(() =>
        {
            try
            {
                AddAPerson();
                DataBase.ListOfHumans.RemoveAt(WindowParameters.IndexInList);
                UIManager.Instance.ChangeCurrentWindowOn<ListForEdit>(gameObject);
            }
            catch (Exception exception)
            {
                OutputField.text = exception.Message;
            }
        });
        LoadPersonInfo();
        CompletionButton.nameOnButton.text = "Edit";
    }
}
