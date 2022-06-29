using TMPro;

public class PersonDetail : PersonInputOutput
{
    private void Start()
    {
        addButton.onClick.AddListener(() => { ChangeCurrentWindow(StartWindow); });
        InitialConfiguration();
        addButton.transform.GetComponent<ButtonController>().NameOnButton.text = "Back";
        InputFieldsSetUp();
        LoadPersonInfo();
        PlaceHolderDisable();
    }

    private void PlaceHolderDisable()
    {
        foreach (var inputField in inputFields)
        {
            inputField.GetComponent<TMP_InputField>().enabled = false;
        }

        foreach (var inputField in birthday)
        {
            inputField.enabled = false;
        }
    }
}