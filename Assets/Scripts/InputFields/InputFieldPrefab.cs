using TMPro;
using UnityEngine;

public class InputFieldPrefab : MonoBehaviour
{
    public TextMeshProUGUI fieldName;
    public TMP_InputField inputField;
    public GameObject inputFieldGameObject;

    public void SetParameters(string nameOfField, TMP_InputField.ContentType contentType, int characterLimit = 0)
    {
        fieldName.text = nameOfField;
        inputField.contentType = contentType;
        inputField.characterLimit = characterLimit;
        inputFieldGameObject.SetActive(true);
    }
}
