using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    private StartWindow _startWindow;
        
    // Start is called before the first frame update
    void Start()
    {
        _startWindow = (StartWindow)GetComponentInParent<UIManager>().GetWindow<StartWindow>();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            transform.parent.GetComponent<Window>().ChangeCurrentWindow(_startWindow);
        });
    }
}
