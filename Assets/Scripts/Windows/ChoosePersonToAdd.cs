using UnityEngine;
using UnityEngine.UI;

public class ChoosePersonToAdd : Window
{
    [SerializeField] private Button _addStudentButton;
    [SerializeField] private Button _addEmployeeButton;
    [SerializeField] private Button _addDriverButton;

    private void Start()
    {
        var windowParameters = new WindowParameters();

        _addStudentButton.onClick.AddListener(() =>
        {
            windowParameters.SetType<Student>();
            UIManager.Instance.ChangeCurrentWindowOn<InputPerson>(gameObject, windowParameters);
        });
        _addEmployeeButton.onClick.AddListener(() =>
        {
            windowParameters.SetType<Employee>();
            UIManager.Instance.ChangeCurrentWindowOn<InputPerson>(gameObject, windowParameters);
        });
        _addDriverButton.onClick.AddListener(() =>
        {
            windowParameters.SetType<Driver>();
            UIManager.Instance.ChangeCurrentWindowOn<InputPerson>(gameObject, windowParameters);
        });
    }
}
