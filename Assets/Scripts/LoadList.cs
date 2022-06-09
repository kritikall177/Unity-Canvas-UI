using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadList : MonoBehaviour
{
    public GameObject NameObject;
    private List<GameObject> nameList = new List<GameObject>();
    void Start()
    {
        for (var i = 0; i < ManagerUI.List.Count; i++)
        {
            nameList.Add(Instantiate(NameObject, transform));
            nameList[i].transform.GetChild(0).transform.GetComponent<Text>().text = ManagerUI.List[i].name;
        }
    }
}
