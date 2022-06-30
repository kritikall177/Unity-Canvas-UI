public class PersonDetail : PersonInputOutput
{
    protected override void Start()
    {
        base.Start();
        CompletionButton.button.onClick.AddListener(() =>
        {
            UIManager.Instance.ChangeCurrentWindowOn<ListForEdit>(gameObject);
        });
        LoadPersonInfo();
        FieldsReadOnly();
        CompletionButton.nameOnButton.text = "Back";
    }

    private void FieldsReadOnly()
    {
        Name.inputField.enabled = false;
        Surname.inputField.enabled = false;
        Patronymic.inputField.enabled = false;
        _birthday.InputShutdown();

        switch (WindowParameters.Type.Name)
        {
            case nameof(Student):
                Faculty.inputField.enabled = false;
                Year.inputField.enabled = false;
                Group.inputField.enabled = false;
                break;
            case nameof(Employee):
                Organization.inputField.enabled = false;
                Salary.inputField.enabled = false;
                Experience.inputField.enabled = false;
                break;
            case nameof(Driver):
                CarBrand.inputField.enabled = false;
                CarModel.inputField.enabled = false;
                goto case nameof(Employee);
        }
    }
}