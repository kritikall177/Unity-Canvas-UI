using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadList : MonoBehaviour
{
    public GameObject NameObject;
    private List<GameObject> nameList = new List<GameObject>();
    void OnEnable()
    {
        switch (NameObject.name)
        {
            case "Button Edit":
            case "Button Delete":
            case "Button print detail":
                for (var i = 0; i < ManagerUI.List.Count; i++)
                {
                    nameList.Add(Instantiate(NameObject, transform));
                    nameList[i].transform.GetComponent<ButtonController>().indexOfList = i;
                    nameList[i].transform.GetChild(0).transform.GetComponent<Text>().text = ManagerUI.List[i].Name;
                }
                break;
            case "Person Info":
                for (var i = 0; i < ManagerUI.List.Count; i++)
                {
                    nameList.Add(Instantiate(NameObject, transform));
                    nameList[i].transform.GetChild(0).GetChild(0).transform.GetComponent<Text>().text = ManagerUI.List[i].Name;
                    nameList[i].transform.GetChild(1).GetChild(0).transform.GetComponent<Text>().text = ManagerUI.List[i].Surname;
                    nameList[i].transform.GetChild(2).GetChild(0).transform.GetComponent<Text>().text = ManagerUI.List[i].Patronymic;
                    nameList[i].transform.GetChild(3).GetChild(0).GetChild(0).transform.GetComponent<Text>().text =
                        Convert.ToString(ManagerUI.List[i].Birthday.Year);
                    nameList[i].transform.GetChild(3).GetChild(1).GetChild(0).transform.GetComponent<Text>().text =
                        Convert.ToString(ManagerUI.List[i].Birthday.Month);
                    nameList[i].transform.GetChild(3).GetChild(2).GetChild(0).transform.GetComponent<Text>().text =
                        Convert.ToString(ManagerUI.List[i].Birthday.Day);
                }
                break;
        }
    }
}
