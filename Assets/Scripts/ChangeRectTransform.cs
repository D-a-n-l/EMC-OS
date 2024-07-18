using UnityEngine;

public class ChangeRectTransform : MonoBehaviour
{
    [SerializeField]
    private Vector2 defaultLeftAndRight;

    [SerializeField]
    private Vector2 orientationLeftAndRight;

    [SerializeField]
    private Vector2 posYAndHeight;

    private RectTransform rectTransform;

    private bool isChange = false;

    private void Start() => rectTransform = GetComponent<RectTransform>();

    private void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.Portrait)
        {
            if (rectTransform.offsetMin.x != orientationLeftAndRight.x && isChange == true)
            {
                SetRect(orientationLeftAndRight, posYAndHeight);
            }
            else if (rectTransform.offsetMin.x != defaultLeftAndRight.x && isChange == false)
            {
                SetRect(defaultLeftAndRight, posYAndHeight);
            }
        }
    }

    public void SetIsChange(bool value) => isChange = value;

    private void SetRect(Vector2 value1, Vector2 value2)
    {
        rectTransform.offsetMin = new Vector2(value1.x, value2.x);
        rectTransform.offsetMax = new Vector2(value1.y, value2.y);
    }
}