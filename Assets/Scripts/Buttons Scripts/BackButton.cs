using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] private Transform _currentPosition;
    private StartWindow _startWindow;

    private void Start()
    {
        _startWindow = DataBase.GetWindow<StartWindow>();

        GetComponent<Button>().onClick.AddListener(() =>
        {
            _currentPosition.GetComponent<Window>().ChangeCurrentWindow(_startWindow);
        });
    }
}
