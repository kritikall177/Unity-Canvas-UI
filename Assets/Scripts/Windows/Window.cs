using UnityEngine;

public abstract class Window : MonoBehaviour
{
    public void Open(Transform position)
    {
        Instantiate(this, position);
    }

    public void Close()
    {
        Destroy(gameObject);
    }

    public void ChangeCurrentWindow(Window sender)
    {
        sender.Open(transform.parent);
        Close();
    }
}
