using UnityEngine;
using UnityEngine.UI;

public class BackButtonAndroid : MonoBehaviour
{
    [SerializeField]
    private Button buttonBack;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (buttonBack != null)
                if (buttonBack.gameObject.activeSelf == true && buttonBack.interactable == true)
                    buttonBack.onClick.Invoke();
        }
    }
}