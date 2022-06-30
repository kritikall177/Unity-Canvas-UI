using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PersonForList : MonoBehaviour
{
    [SerializeField] public GameObject GameObject;
    [SerializeField] public TextMeshProUGUI Name;
    [SerializeField] public ButtonController EditButton;
    [SerializeField] public ButtonController DeleteButton;
    [SerializeField] public ButtonController DetailButton;
}
