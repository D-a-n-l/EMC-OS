using UnityEngine;

public class Orientation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] landscapeButton;

    [SerializeField]
    private GameObject[] portraitButton;

    private bool isChange = false;

    private void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft && isChange == true)
        {
            if(landscapeButton[0].activeSelf == false) 
            {
                ChangeButtons(landscapeButton, true, false);
            }
        }
        else if (Screen.orientation == ScreenOrientation.Portrait && isChange == true)
        {
            if (portraitButton[0].activeSelf == false)
            {
                ChangeButtons(portraitButton, false, true);
            }
        }
    }

    private void ChangeButtons(GameObject[] targetGameObjects, bool lasndscape, bool portrait)
    {
        for (int i = 0; i < targetGameObjects.Length; i++)
        {
            landscapeButton[i].SetActive(lasndscape);

            portraitButton[i].SetActive(portrait);
        }
    }

    public void SetIsChange(bool value) => isChange = value;
}