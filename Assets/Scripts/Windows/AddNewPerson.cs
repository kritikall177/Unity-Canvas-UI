using UnityEngine;
using UnityEngine.UI;

public class AddNewPerson : Window
{
    [SerializeField] private Button _addStudentButton;
    [SerializeField] private Button _addEmployeeButton;
    [SerializeField] private Button _addDriverButton;

    private InputPerson _inputPerson;

    private void Start()
    {
        _inputPerson = DataBase.GetWindow<InputPerson>();

        _addStudentButton.onClick.AddListener(() => { ChangeCurrentWindow(_inputPerson, Person.Student); });
        _addEmployeeButton.onClick.AddListener(() => { ChangeCurrentWindow(_inputPerson, Person.Employee); });
        _addDriverButton.onClick.AddListener(() => { ChangeCurrentWindow(_inputPerson, Person.Driver); });
    }

    private void ChangeCurrentWindow(InputPerson sender, Person type)
    {
        sender.Open(transform.parent, type);
        Close();
    }
}
