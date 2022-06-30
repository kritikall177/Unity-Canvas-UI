using UnityEngine;

public abstract class Window : MonoBehaviour
{
    protected WindowParameters WindowParameters;

    public void OnCreate(WindowParameters windowParameters)
    {
        if (windowParameters != null)
        {
            WindowParameters = windowParameters;
        }
    }
}