using System;
using TMPro;
using UnityEngine;


public class PersonMainInfo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _surname;
    [SerializeField] private TextMeshProUGUI _patronymic;
    [SerializeField] private TextMeshProUGUI _year;
    [SerializeField] private TextMeshProUGUI _month;
    [SerializeField] private TextMeshProUGUI _day;

    public void SetInfo(Human human)
    {
        _name.text = human.Name;
        _surname.text = human.Surname;
        _patronymic.text = human.Patronymic;
        _year.text = Convert.ToString(human.Birthday.Year);
        _month.text = Convert.ToString(human.Birthday.Month);
        _day.text = Convert.ToString(human.Birthday.Day);
    }
}