using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
  [SerializeField] private Button _button;
  
  private void Start()
  {
    _button.onClick.AddListener(Application.Quit);
  }
}
