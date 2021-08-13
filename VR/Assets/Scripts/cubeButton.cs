using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeButton : MonoBehaviour
{
    public GameObject gameObj;

    void OnTriggerEnter()
    {
        gameObj.transform.localPosition = new Vector3(1, gameObj.transform.localPosition.y, gameObj.transform.localPosition.z);
    }
}
