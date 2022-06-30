using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<Window> _listOfWindows;

    public static UIManager Instance { get; private set; }

    private void Start()
    {
        Instance = this;
        Open<MainMenu>();
    }

    private void Open<T>(WindowParameters windowParameters = null) where T : Window
    {
        var prefab = GetWindow<T>();
        var instance = Instantiate(prefab, transform);
        instance.OnCreate(windowParameters);
    }

    private void Close(GameObject window)
    {
        Destroy(window);
    }

    public void ChangeCurrentWindowOn<T>(GameObject windowToClose, WindowParameters windowParameters = null)
        where T : Window
    {
        Close(windowToClose);
        Open<T>(windowParameters);
    }

    private T GetWindow<T>() where T : Window
    {
        foreach (var window in _listOfWindows)
        {
            if (window is T resultWindow)
            {
                return resultWindow;
            }
        }

        return null;
    }
}