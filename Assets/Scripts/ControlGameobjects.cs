using System.Collections.Generic;
using UnityEngine;

public class ControlGameobjects : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> gameObjects;

    [SerializeField]
    private bool value = false;

    public bool _value { get { return value; } }

    public void AddObject(GameObject newObject)
    {
        gameObjects.Add(newObject);
    }

    public void Control(bool setActive)
    {
        value = setActive;

        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].SetActive(setActive);
        }
    }
}