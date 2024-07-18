using UnityEngine;

public class OpenFiles : MonoBehaviour
{
    public void OpenFile(string fileLink) => Application.OpenURL(fileLink);
}