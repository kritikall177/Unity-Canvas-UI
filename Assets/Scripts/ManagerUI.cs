using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ManagerUI : MonoBehaviour
{
    public GameObject MainWindow;
    private static GameObject WindowNow { get; set; }
    public static Transform canvas;
    public static List<Human> List = new List<Human>();

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Transform>();
        WindowNow = Instantiate(MainWindow, transform);
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    public static void DestroyWindow()
    {
        Destroy(WindowNow);
    }

    public static void SetWindow(GameObject window)
    {
        Destroy(WindowNow);
        WindowNow = Instantiate(window, canvas);
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
