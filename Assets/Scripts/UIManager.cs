using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<Window> Windows;

    void Start()
    {
        foreach(var window in Windows)
        {
            if (window is StartWindow)
            {
                window.Open(transform);
            }
        }
    }
    
    public Window GetWindow<T> () where T : Window
    {
        foreach(var window in Windows)
        {
            if (window is T)
                return window;
        }
        return null;
    }
}
