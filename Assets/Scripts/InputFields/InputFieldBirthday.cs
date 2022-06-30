using System;
using TMPro;
using UnityEngine;

public class InputFieldBirthday : MonoBehaviour
{
    public TextMeshProUGUI fieldName;
    public TMP_InputField yearField;
    public TMP_InputField monthField;
    public TMP_InputField dayField;
    public GameObject inputFieldGameObject;

    private void Start()
    {
        inputFieldGameObject.SetActive(true);
        fieldName.text = "Birthday";
        yearField.characterLimit = 4;
        yearField.contentType = TMP_InputField.ContentType.IntegerNumber;
        monthField.characterLimit = 2;
        monthField.contentType = TMP_InputField.ContentType.IntegerNumber;
        dayField.characterLimit = 2;
        dayField.contentType = TMP_InputField.ContentType.IntegerNumber;
    }

    public void SetActive(bool value)
    {
        inputFieldGameObject.SetActive(value);
    }

    public DateTime GetDateTime()
    {
        var year = Convert.ToInt32(yearField.text);
        var month = Convert.ToInt32(monthField.text);
        var day = Convert.ToInt32(dayField.text);
        if (year <= 0 || year > DateTime.Now.Year ||
            month > 12 || month < 1 || day > 31 ||
            day < 1)
        {
            throw new Exception("Invalid date input");
        }

        return new DateTime(year, month, day);
    }

    public void SetDateTime(DateTime birthday)
    {
        yearField.text = Convert.ToString(birthday.Year);
        monthField.text = Convert.ToString(birthday.Month);
        dayField.text = Convert.ToString(birthday.Day);
    }

    public void InputShutdown()
    {
        yearField.enabled = false;
        monthField.enabled = false;
        dayField.enabled = false;
    }
}