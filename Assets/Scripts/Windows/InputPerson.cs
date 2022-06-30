using System;
using UnityEngine;

public class InputPerson : PersonInputOutput
{
    protected override void Start()
    {
        base.Start();
        CompletionButton.button.onClick.AddListener(() =>
        {
            try
            {
                AddAPerson();
                UIManager.Instance.ChangeCurrentWindowOn<MainMenu>(gameObject);
            }
            catch (Exception exception)
            {
                Debug.Log(exception);
                OutputField.text = exception.Message;
            }
        });
    }
}
