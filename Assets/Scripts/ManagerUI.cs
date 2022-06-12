using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ManagerUI : MonoBehaviour
{
    public GameObject MainWindow;
    private static GameObject WindowNow { get; set; }
    private static Transform canvas;
    public static readonly List<Human> List = new List<Human>();

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Transform>();
        WindowNow = Instantiate(MainWindow, transform);
        //
        var a = gameObject.AddComponent<Student>();
        a.SetName("Student");
        a.SetSurname("SurStudent");
        a.SetPatronymic("PatrStudent");
        a.SetDate(DateTime.Now);
        a.SetFaculty("fit");
        a.SetGroup("20vs");
        a.SetYear(1);
        List.Add(a);
        //
        var b = gameObject.AddComponent<Employee>();
        b.SetName("Employee");
        b.SetSurname("SurEmployee");
        b.SetPatronymic("PatrEmployee");
        b.SetDate(DateTime.Now);
        b.SetExperience(2);
        b.SetOrganization("psu");
        b.SetSalary(12);
        List.Add(b);
        //
        var c = gameObject.AddComponent<Driver>();
        c.SetName("Driver");
        c.SetSurname("SurDriver");
        c.SetPatronymic("PatrDriver");
        c.SetDate(DateTime.Now);
        c.SetExperience(2);
        c.SetOrganization("psu");
        c.SetSalary(12);
        c.SetCarBrand("zaz");
        c.SetCarModel("ыфа");
        List.Add(c);
    }

    public static void SetWindow(GameObject window)
    {
        Destroy(WindowNow);
        WindowNow = Instantiate(window, canvas);
    }

    public static void SetWindow(GameObject window, int index)
    {
        SetWindow(window);
        var person = List[index];
        switch (person.GetType().Name)
        {
            case "Student":
                ChoosePerson(1);
                break;
            case "Employee":
                ChoosePerson(2);
                break;
            case "Driver":
                ChoosePerson(3);
                break;
        }
    }

    public static void SetWindowForEdit(GameObject window, int index)
    {
        SetWindow(window, index);
        WindowNow.GetComponent<EditPerson>().index = index;
        WindowNow.GetComponent<EditPerson>().Edit(List[index]);
    }

    public static void SetWindowForPrint(GameObject window, int index)
    {
        SetWindow(window, index);
        WindowNow.GetComponent<PrintPersonInformation>().index = index;
        WindowNow.GetComponent<PrintPersonInformation>().PrintDetail(List[index]);
    }

    public static void ChoosePerson(int numberOfChild)
    {
        switch (numberOfChild)
        {
            case 1:
                WindowNow.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 2:
                WindowNow.transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 3:
                WindowNow.transform.GetChild(2).gameObject.SetActive(true);
                WindowNow.transform.GetChild(3).gameObject.SetActive(true);
                break;
            default:
                WindowNow.transform.GetChild(1).gameObject.SetActive(true);
                break;
        }
    }
}
