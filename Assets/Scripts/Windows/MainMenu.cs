using UnityEngine;
using UnityEngine.UI;

public class MainMenu : Window
{
    [SerializeField] private Button _addNewPersonButton;
    [SerializeField] private Button _listForEditButton;
    [SerializeField] private Button _listOfAllPersonsButton;

    private void Start()
    {
        _addNewPersonButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ChangeCurrentWindowOn<ChoosePersonToAdd>(gameObject);
        });
        _listForEditButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ChangeCurrentWindowOn<ListForEdit>(gameObject);
        });
        _listOfAllPersonsButton.onClick.AddListener(() =>
        {
            UIManager.Instance.ChangeCurrentWindowOn<ListOfAllPersons>(gameObject);
        });
    }
}
