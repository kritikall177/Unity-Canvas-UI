using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Window : MonoBehaviour
{
    /*public delegate void OpenEventHandler(Window sender);
    public event OpenEventHandler OnOpen;*/
    //В чём разница между верхним и нижним?
    //public UnityAction<Window> OnOpen;

    public void Open(Transform position)
    {
        Instantiate(this, position);
    }

    public void Close()
    {
        Destroy(gameObject);
    }

    protected void ChangeCurrentWindow(Window sender)
    {
        sender.Open(transform.parent);
        Close();
    }
}
