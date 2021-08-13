using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidingFloor : MonoBehaviour
{
    public List<GameObject> objectList;

    void OnTriggerEnter()
    {
        foreach (var gameObj in objectList)
        {
            if (gameObj.activeSelf)
                gameObj.SetActive(false);
            else
                gameObj.SetActive(true);
        }
    }
}
