using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
  private void OnEnable()
  {
    GetComponent<Button>().onClick.AddListener(Application.Quit);
  }
  
}
