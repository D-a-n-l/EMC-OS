using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    private RectTransform target;

    [Range(0f, 1f)]
    [SerializeField]
    private float strengthParallax;

    private Vector3 targetPreviousPosition;

    private void Start() => targetPreviousPosition = target.position;

    private void Update()
    {
        if(targetPreviousPosition != target.position)
        {
            var delta = target.position - targetPreviousPosition;

            targetPreviousPosition = target.position;

            transform.position += delta * strengthParallax;
        }
    }
}