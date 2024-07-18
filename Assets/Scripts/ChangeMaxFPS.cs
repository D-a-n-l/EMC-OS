using UnityEngine;

public class ChangeMaxFPS : MonoBehaviour
{
    [SerializeField]
    private int targetFPS;

    private void Start()
    {
        Application.targetFrameRate = targetFPS;
    }
}