using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public int _indexOfList = -1;
    public void CreateWindow(GameObject window)
    {
        ManagerUI.SetWindow(window);
    }

    public void CreateWindowForEdit(GameObject window, int index)
    {
        ManagerUI.SetWindowForEdit(window, index);
    }
    
    public void CreateWindowForPrint(GameObject window, int index)
    {
        ManagerUI.SetWindowForPrint(window, index);
    }
    
    public void ChoosePerson(int numberOfChild)
    {
        ManagerUI.ChoosePerson(numberOfChild);
    }

    public void ChoosePersonForEdit(GameObject window)
    {
        if (_indexOfList == -1) return;
        CreateWindowForEdit(window, _indexOfList);
    }
    
    public void ChoosePersonForPrint(GameObject window)
    {
        if (_indexOfList == -1) return;
        CreateWindowForPrint(window, _indexOfList);
    }

    public void DeletePerson()
    {
        ManagerUI.List.RemoveAt(_indexOfList);
        Destroy(gameObject);
    }
}
