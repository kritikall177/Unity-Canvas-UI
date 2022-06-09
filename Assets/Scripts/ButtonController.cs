using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void CreateWindow(GameObject window)
    {
        ManagerUI.SetWindow(window);
    }

    public void ChoosePerson(int numberOfChild)
    {
        ManagerUI.ChoosePerson(numberOfChild);
    }
}
