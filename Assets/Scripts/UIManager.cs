using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<Window> _windows;

    private void Start()
    {
        foreach (var window in _windows)
        {
            DataBase.ListOfWindows.Add(window);
        }

        DataBase.GetWindow<StartWindow>().Open(transform);
    }
}
