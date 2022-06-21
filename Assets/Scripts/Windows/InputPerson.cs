using System;

public class InputPerson : PersonInputOutput
{
    private void Start()
    {
        addButton.onClick.AddListener(() =>
        {
            try
            {
                AddingPerson();
                ChangeCurrentWindow(StartWindow);
            }
            catch (Exception exception)
            {
                outputField.text = exception.Message;
            }
        });
        InitialConfiguration();
        InputFieldsSetUp();
    }
}
