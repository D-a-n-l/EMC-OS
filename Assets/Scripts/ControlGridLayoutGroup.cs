using UnityEngine;

public class ControlGridLayoutGroup : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.GridLayoutGroup gridLayoutGroup;

    [SerializeField]
    private ControlGameobjects controlGameobjects;

    [SerializeField]
    private UnityEngine.UI.GridLayoutGroup.Constraint constraint;

    [SerializeField]
    private Vector2 spacing;

    [SerializeField]
    private RectOffset padding;

    [SerializeField]
    private Vector2 landScapeCellSize;

    [SerializeField]
    private int landScapeColumnCount;

    [SerializeField]
    private Vector2 portraitCellSize;

    [SerializeField]
    private int portraitColumnCount;

    private void Update() { if (controlGameobjects._value == true) SetVar(); }

    public void SetVar()
    {
        gridLayoutGroup.spacing = spacing;

        gridLayoutGroup.padding = padding;

        gridLayoutGroup.constraint = constraint;

        if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        {
            gridLayoutGroup.cellSize = landScapeCellSize;

            gridLayoutGroup.constraintCount = landScapeColumnCount;
        }
        else if (Screen.orientation == ScreenOrientation.Portrait)
        {
            gridLayoutGroup.cellSize = portraitCellSize;

            gridLayoutGroup.constraintCount = portraitColumnCount;
        }
    }
}