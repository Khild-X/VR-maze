using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject door;
    bool isActive;

    void OnTriggerEnter()
    {
        isActive = true;
    }

    void Update()
    {
        if (isActive)
        {
            if (door.transform.position.y < 14.14f)
            {
                door.transform.position += new Vector3(0, 0.02f, 0);
            }
        }
    }
}
