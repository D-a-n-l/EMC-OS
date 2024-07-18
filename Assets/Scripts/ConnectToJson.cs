using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class ConnectToJson : MonoBehaviour
{
    [SerializeField]
    private ParametrsButton[] buttons;

    [SerializeField]
    private string pathToJson;

    [SerializeField]
    private ControlGameobjects controlGameobjectsPractical;

    private void Start()
    {
        StartCoroutine(ReadJson());
    }

    private IEnumerator ReadJson()
    {
        UnityWebRequest request = UnityWebRequest.Get(pathToJson);
        
        yield return request.SendWebRequest();

        Root jsonFile = JsonConvert.DeserializeObject<Root>(request.downloadHandler.text);

        if (jsonFile.Count >= buttons.Length + 1)
            jsonFile.Count = buttons.Length;
        else if(jsonFile.Count < 0)
            jsonFile.Count = 0;
        
        for (int i = 0; i < jsonFile.Count; i++)
        {
            int index = i;

            buttons[index].namePractical.text = jsonFile.ActiveButtons[index].Name;

            buttons[index].namePractical.fontSize = jsonFile.ActiveButtons[index].SizeName;

            buttons[index].fullNamePractical.text = jsonFile.ActiveButtons[index].FullName;

            buttons[index].fullNamePractical.fontSize = jsonFile.ActiveButtons[index].SizeFullName;

            buttons[index].button.onClick.AddListener(() => Application.OpenURL(jsonFile.ActiveButtons[index].Link));

            if (buttons[index].secondButton != null)
                buttons[index].secondButton.onClick.AddListener(() => Application.OpenURL(jsonFile.ActiveButtons[index].Link));

            if (buttons[index].thirdButton != null)
                buttons[index].thirdButton.onClick.AddListener(() => Application.OpenURL(jsonFile.ActiveButtons[index].Link));

            controlGameobjectsPractical.AddObject(buttons[index].button.gameObject);

            if (buttons[index].namePractical.fontSize < 0)
                buttons[index].namePractical.fontSize = 0;

            if (buttons[index].fullNamePractical.fontSize < 0)
                buttons[index].fullNamePractical.fontSize = 0;
        }
    } 
}

[System.Serializable]
public class ParametrsButton
{
    public Button button;

    public Button secondButton;

    public Button thirdButton;

    public Text namePractical;

    public Text fullNamePractical;
}