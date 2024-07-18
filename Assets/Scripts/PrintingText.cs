using UnityEngine;
using UnityEngine.UI;

public class PrintingText : MonoBehaviour
{
    [SerializeField]
    private string typedText;

    [SerializeField]
    private Text textComponent;

    private void Start()
    {
        StartPrint(typedText);
    }

    public void StartPrint(string newText)
    {
        textComponent.text = "";

        foreach (var txt in newText)
        {
            if (txt == 'n')
                textComponent.text += "\n";
            else
                textComponent.text += txt;
        }
    }
}