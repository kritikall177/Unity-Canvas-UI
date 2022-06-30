using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] private Window _currentWindow;
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(() =>
        {
            UIManager.Instance.ChangeCurrentWindowOn<MainMenu>(_currentWindow.gameObject);
        });
    }
}
